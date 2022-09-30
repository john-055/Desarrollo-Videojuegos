using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López
    Fecha: 25/09/2022
    Grupo:  GDGS2102
    Script: Se crean los animales cada 2 segundos y son aleotoriamente
*/

public class CreateAnimals : MonoBehaviour
{
    public GameObject[] animales;
    // Start is called before the first frame update
    void Start()
    {
        // Invoca la repeticion de los animales
        InvokeRepeating("CrearAnimal", 2, 1.5F);
    }

    // Update is called once per frame
    void Update()
    {
 

    }

    void CrearAnimal(){
        // Variables para crear los rangos para la creacion de los animales
        int aleatorio = Random.Range(0, 3);
        int x = Random.Range(-10, 10);
        // Instanciacion de los animales
         Instantiate(animales[aleatorio], new Vector3(x, 0, 15), animales[0].transform.rotation);

    }   
}
