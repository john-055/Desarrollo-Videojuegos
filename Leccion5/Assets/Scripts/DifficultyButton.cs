using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para crear la dificultad del juego.
*/


public class DifficultyButton : MonoBehaviour
{
    //Varible para hacer referencia a la dificultad de los botones
     private Button button;

     //Variable objeto GameManager
     private GameManager gameManager;

     //Variable para la dificultad
     public int difficulty;

    void Start()
    {
        //Llamamos el objeto Button y se lo asignamos a la Varible button
        button = GetComponent<Button>();
        //Método onClick para reconocer si se toca el boton
        button.onClick.AddListener(SetDifficulty);
        //Se crea la instancia y se la asigna a la variable gameManager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }
}
