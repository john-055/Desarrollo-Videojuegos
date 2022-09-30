using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para la creacion de objetos con ayuda de
    los prefabs, en este caso los objetos pelotas,
    se crearan varios objetos de pelotas de diferentes colores.
*/

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
   // private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Variable para realizar un arreglo, que ayudara a crear las pelotas de diferentes colores
        int pelota = Random.Range(0, 3);

        // Generar índice de pelota aleatorio y posición de generación aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

         // Instanciar la pelota en una ubicación de generación aleatoria
        Instantiate(ballPrefabs[pelota], spawnPos, ballPrefabs[pelota].transform.rotation);

        startDelay = Random.Range(1, 5);

        Invoke("SpawnRandomBall", startDelay);
    }

}
