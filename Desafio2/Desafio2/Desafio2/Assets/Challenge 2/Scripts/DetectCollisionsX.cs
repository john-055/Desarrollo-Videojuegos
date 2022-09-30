using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para detectar las eliminaciones, esto quiere decir
    que cuando una pelota toque un perro esta sera eliminada.
*/

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
