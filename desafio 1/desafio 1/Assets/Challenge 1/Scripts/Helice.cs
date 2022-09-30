using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para poder girar el helice de la avioneta y que siga cuando se mueva
*/

public class Helice : MonoBehaviour
{
    // Crear una variable publica para poder controlarla desde unity y tiene una velocidad de 1200
    public float velocidad = 1200.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Metodo para que la helice gire con el componente "transfornm" y "Rotate"
        // con Vector3 utilizamos para que gire desde el eje Z y girar hacia delante y multiplicamos por la variable velocidad
        transform.Rotate(Vector3.forward * velocidad);
        
    }
}
