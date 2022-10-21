using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para crear los obstaculos en el juego.
*/


public class SpawnManager : MonoBehaviour
{
    //Guarda las instacias de los objetos
    public GameObject obstaclePrefab;
    //Posición de los objetos
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //Tiempo de espera
    private float startDelay = 2;
    //Tiempo para repitirse
    private float repeatRate = 2;
    //Variable de tipo PlayerController
    private PlayerController playerControllerScript;

   
    void Start()
    {
        //Se le llama la funcion para que se este repitiendo en cuarquier momento
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Metodo para crear los obstaculos
    void SpawnObstacle()
    {
        //Condición si el juego aun no termina
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
