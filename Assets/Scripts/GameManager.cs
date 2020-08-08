﻿
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
  
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            // restart game
            Invoke("Restart", restartDelay);

        }


    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*SceneManager.GetActiveScene().name returns the name of current scene
         and 
         */
    }



}
