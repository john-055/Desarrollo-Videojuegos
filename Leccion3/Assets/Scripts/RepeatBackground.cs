using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script : Script Esta para Repitir el fondo.
*/

public class RepeatBackground : MonoBehaviour
{
    //variable de tipo Vector3
    private Vector3 startPos;
    //variable para guardar el tamaño de la repetición del fondo
    private float repeatWidth;
  
    void Start()
    {
        //Posción del fondo
        startPos = transform.position;
        //Se divide el fondo en 2
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }



    void Update()
    {
        //Condición repertir fondo en que momento
        if(transform.position.x < startPos.x - repeatWidth)
        {
            //Nueva posción
            transform.position = startPos;
        }
    }
}
