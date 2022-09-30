using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para que el player a crear varios objetos perros.
*/

public class PlayerControllerX : MonoBehaviour
{
    private float tiempoDisparo = 1;
    private float tiempoSigDisparo = 0;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoSigDisparo)
        {
            tiempoSigDisparo = Time.time + tiempoDisparo;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
