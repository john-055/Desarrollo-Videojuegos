using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para repitir el fondo.
*/

public class RepeatBackgroundX : MonoBehaviour
{
    //Se crea la variable de Vector3 para la posición
    private Vector3 startPos;
    //Variable para el ancho del fondo
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        
        // Se cambia la variable y la x
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


