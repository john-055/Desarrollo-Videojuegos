using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para destruir el objeto
*/

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
