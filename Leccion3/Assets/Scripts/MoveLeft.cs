using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para dar movimiento el fondo y los objetos.
*/


public class MoveLeft : MonoBehaviour
{
    //Es la variable para la velocidad de los objetos
    private float speed = 30;
    //Se crea variable del playerController
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        //Se hace referencia al Script PlayerController
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Una condición para si el juego ah terminado
        if(playerControllerScript.gameOver == false)
        {
            //Trasladar fondo y objetos a la izquierda
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        //Condicion si los objetos han llegado al limite
        if(transform.position.x < leftBound && gameObject.CompareTag("obstacle"))
        {
            //Cuando llegan al limie se destruyen los obstaculos
            Destroy(gameObject);
        }
    }
}
