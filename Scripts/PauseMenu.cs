using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenuUI;
    //Setting a starting status of a game as Non-Paused
    public static bool GameIsPaused = false;
	
	
	void Update () {
        //When a player press key "Esc"
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            //and if the game is currently paused
            if (GameIsPaused)
            {
                //the game will be playing again
                Resume();
            }   else
              {
                //otherwise the game will pause
                Pause();
              }

        }



    }
        public void Resume ()
        {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
            }

        void Pause ()
        {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
            }


    //Option to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }

}


