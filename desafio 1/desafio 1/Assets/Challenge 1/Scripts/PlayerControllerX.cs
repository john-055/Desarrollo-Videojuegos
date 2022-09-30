using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
   --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López 
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utilza para poder controlar la avioneta y asignar la velocidad y la rotacion 
*/

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        // move the plane forward at a constant rate
        // Se cambio Back por "Forward" para avanzar adelante
        // Se multiplica por time que se ejecutara una vez por segundo 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        // Se Multiplica por la variable VerticalInput para poder rotar
        // Utilizar Left para que valla de forma negativa
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
