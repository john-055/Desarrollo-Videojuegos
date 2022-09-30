using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para poder mover el controlador player y tambien crear una pizzas en la posision del player
*/

public class MoveHuman : MonoBehaviour
{
    public float vel = 100.0F;
    public float maximo = 22;
    public GameObject Pizza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            Instantiate(Pizza, transform.position, Pizza.transform.rotation);
        }
        
        if(transform.position.x > maximo){
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -maximo){
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z);
        }
        // Movilidad del player de manera horizontal
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
    }
}
