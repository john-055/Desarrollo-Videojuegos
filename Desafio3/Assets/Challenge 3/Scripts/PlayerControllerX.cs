using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para las funciones del player.
*/

public class PlayerControllerX : MonoBehaviour
{
    //Variable para el status del juego
    public bool gameOver;
    //Variable para la fuerza
    public float floatForce;
    //variable para la gravedad
    private float gravityModifier = 1.5f;
    //Variable Rigibody
    private Rigidbody playerRb;
    //Variable para las animaciones
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    //Variables para los audios
    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;


    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos la gravedad
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        //Inicializamos la varibale
        playerRb = GetComponent<Rigidbody>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
        //Se aplica la fuerza al vector3
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            //Reproducimos la animación
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
