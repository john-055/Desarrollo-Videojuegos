using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para mover los objetos y el fondo.
*/

public class MoveLeftX : MonoBehaviour
{
    //Variable para la velocidad
    public float speed;
    //Hacemos un objeto de tipo PlayerControllerX
    private PlayerControllerX playerControllerScript;
    
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        //Se hace la negacion en la condicion del si el juego aun no termina
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
