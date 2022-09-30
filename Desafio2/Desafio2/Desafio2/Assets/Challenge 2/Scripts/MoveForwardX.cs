using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utilza para el movimiento que tiene el perro para
    que este corra en linea recta al crear un nuevo animal.
*/

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Se Utiliza para mover en linea recta al animal.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
