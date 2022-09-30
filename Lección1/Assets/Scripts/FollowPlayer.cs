using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    --Creación de Videojuegos UTNG
    Autor: Jonathan Anselmo Méndez López
    Fecha: 25/09/2022
    Grupo: GDGS2102
    Script: Se utiliza para el seguimiento del autobus y la posision 
*/

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(4, 11, -26);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //OffSet the camera behi
        transform.position = player.transform.position + offset;
    }
}
