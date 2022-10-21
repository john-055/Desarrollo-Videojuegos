using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
    --Creación de Videojuegos UTNG
    Autor: Méndez López Jonathan Anselmo
    Grupo: GDGS2102
    Fecha: 21/10/2022
    Script: Script para cambir las funciones de las interfaces.
*/


public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    //Variable de TMpro
    public TextMeshProUGUI scoreText;

    //Variable de TMpro
    public TextMeshProUGUI gameOverText;

    //Variable del button
    public Button restartButton;

    public GameObject titleScreen;

    //varible de tiempo de espera
    private float  spawnRate = 1.0f;
    //variable del contador
    private int score;

    //variable para detener el juego
    public bool isGameActive;

   
    void Start()
    {


    }

    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
           
        }
    }
    //Metodo incrementar el puntaje
    public void updateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //Función del fin del juego 
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        
       gameOverText.gameObject.SetActive(true);
       isGameActive = false;
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //iniciar el juego al tocar un button
    public void StartGame( int difficulty)
    {
        //Varibale de inicio de juego
         isGameActive = true;
        //Tiempo en la creación de objetos
        StartCoroutine(SpawnTarget());

        //variable del contador
        score = 0;
        
        //Al seleccionar la dificultad se divide el tiempo por la dificultad
        spawnRate = spawnRate / difficulty;

        //visualizar en la pantalla con 0
       updateScore(0);

       //Desaparecer los botones de inicio de juego
       titleScreen.gameObject.SetActive(false);


    }
}
