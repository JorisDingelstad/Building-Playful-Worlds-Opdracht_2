using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is made using the youtube tutorial provided by Brackeys: (https://www.youtube.com/watch?v=JivuXdrIHK0)

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;

    public GameObject pauseMenuUI;


    void Update ()
    {

	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }	
	}

     public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        paused = false;
        Rotate.collisionL = false; //it's important to set these vars to false aswell 
        Rotate.collisionR = false; //otherwise the player is stuck if you restart the game while the player had gotten stuck before the restart
        Application.LoadLevel(Application.loadedLevel);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
