using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para crear y editar los objetos.
*/


public class Target : MonoBehaviour
{
    //Variable Rigidbody
    private Rigidbody targetRb;
    //Variable GameManager
    private GameManager gameManager;

    //Variable de animación de explosión
    public ParticleSystem explosionParticle;

    //Variables de velocidad
    private float minSpeed = 6;
    private float maxSpeed = 12;
    private float maxTorque = 10;
    //variables de posicion
    private float xRange = 4;
    private float ySpawnPos = -1;

    //Variable para guardar los score
    public int pointValue;


    void Start()
    {
        //Llama a rigidbody y se lo asiganmos a la variable targetRB
        targetRb = GetComponent<Rigidbody>();
        //Instanciamos el Scripts de gameManager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        //RigiBody agregamos una fuerza en dirección ascendente
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        //Aplicamos una rotación a los objetos
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        //Configuramos las poscion
        transform.position = RandomSpawnPos();
    }


    void Update()
    {
        
    }

    
    //Destruir los objetos al tocarlos 
    private void OnMouseDown()
    {
        //condicion para parar el juago
        if(gameManager.isGameActive)
        {
            //Destruir los objetos
            Destroy(gameObject);

            //Sumar los puntos en la Score
            gameManager.updateScore(pointValue);

            //Muestra la animación al tocarlos
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }

    }

    //Destruir los objetos creados en el juego 
    private void OnTriggerEnter(Collider other) {
         Destroy(gameObject);

         if(!gameObject.CompareTag("Bad"))
         {
            gameManager.GameOver();
         }
    }

    //Posción de los obejtos
     Vector3 RandomForce()
    {
        
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), -ySpawnPos);
    }   
}

   

