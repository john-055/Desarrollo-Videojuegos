using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para la ayuda al movimiento de los objetos y la destrucion
*/

public class MoveAnimals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Funcion para destruir a los objetos cuando cruce los limites
        if(transform.position.z < -14.1){
            Destroy(gameObject);
        }

        // Movimiento de los objetos
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }
}
