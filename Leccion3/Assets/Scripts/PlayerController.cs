using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para las funciones del PlayerController.

*/

public class PlayerController : MonoBehaviour
{
    //VARIABLES

    //RigidBody controla la masa del jugador
    private Rigidbody playerRb;
    //Animator para controlar las animaciones
    private Animator playerAnim;
    //ParticleSystem para guardar el objeto de explosión
    public ParticleSystem explosionParticle;
    //ParticleSystem para guardar el objeto de explosión
    public ParticleSystem dirtParticle;
    //AudioClip para guardar el objeto de audio
    public AudioClip jumpSound;
    //AudioClip para guardar el objeto de audio
    public AudioClip crashSound;
    //AudioSource para guardar el objeto de audio
    private AudioSource playerAudio;
    //Variable que guarda el valor del salto
    public float jumpForce = 10;
    //Variable para guardar el valor de la gravedad
    public float gravityModifier;
    //Variable para saber si el judador esta en el suelo
    public bool isOnGround = true;
    //Variable si ah terminado el juego
    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        //Se guardan componentes de RigidBody en playerRb
        playerRb = GetComponent<Rigidbody>();
        //Inicializamos la gravedad por gravedad
        Physics.gravity *= gravityModifier;
        //Se guardan los componentes de Animator en playerAnim
        playerAnim =  GetComponent<Animator>();
        //Se guardan los componentes de AudioSource en playerAudio
        playerAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
            //Condición para dectetar si toca la tecla espacio y si el jugador
            //sigue avanzando sin caerse sin terminar el juego
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){
            //El player salte
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //Se cambia el valor de la variable a false para indicar que no esta en el suelo
            isOnGround = false;
            //Utilizamos un disparador para utilizar esta función
            playerAnim.SetTrigger("Jump_trig");
            //Detenemos las particulas al saltar
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    //Metodo cuando colisionan con los objetos
    private void OnCollisionEnter(Collision collision)
    {
        //Condición si el objeto esta en el suelo sea verdadero para ejecutar las animación
        if(collision.gameObject.CompareTag("Ground"))
        {
            //Valor de que no este saltando
            isOnGround = true;
            dirtParticle.Play();
        }else if(collision.gameObject.CompareTag("obstacle"))
        {
            gameOver = true;
            //Impresion con un mensaje en la consola de game over cuando termina el juego
            Debug.Log("Game Over!");
            //Animacion de muerte
            playerAnim.SetBool("Death_b", true);
            //Animacion numero 1
            playerAnim.SetInteger("DeathType_int", 1);
            //Ejecutamos la animación
            explosionParticle.Play();
            //Detenemos la animación de correr al colicionar
            dirtParticle.Stop();
            //Reproducir el audio de muerte
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
