using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Lanza camida y destruye comida cada vez que se desplaza fuera del area
*/
public class MovePizza : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 34){
            Destroy(gameObject);
        }


        transform.Translate(Vector3.forward * Time.deltaTime * 15);
    }
}
