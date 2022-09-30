using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para asignar nuevas coordenadas al seguir el player
*/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    // Asignar un nuevo Vetctor para las coordenas 
    private Vector3 offset = new Vector3(20,2,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
