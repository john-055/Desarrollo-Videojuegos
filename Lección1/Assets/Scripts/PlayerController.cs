using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  --Creación de Videojuegos UTNG
  Autor: Jonathan Anselmo Méndez López
  Fecha: 25/09/2022
  Grupo: GDGS2102
  Script: Se utilza para mover el autobus y la velocidad
*/

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      // mover el autobus 
      //transform.Translate(0, 0, 1);
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
      
    }
}
