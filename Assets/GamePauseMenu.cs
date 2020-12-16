using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseMenu : MonoBehaviour
{
    // GameIsPaused
    public static bool GameIsPaused = false;

    // Pause Menu
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        // Hide Pause Menu
        PauseMenuUI.SetActive(false);
        // Unfreeze Game
        Time.timeScale = 1;
        // Game Not Paused
        GameIsPaused = false;
        // Turn on audio
        AudioListener.volume = 1f;
    }

    void Pause()
    {
        // Show Pause Menu
        PauseMenuUI.SetActive(true);
        // Freeze Game
        Time.timeScale = 0;
        // Game Paused
        GameIsPaused = true;
        // Turn off audio
        AudioListener.volume = 0;
    }

    public void QuitGame()
    {
        Debug.Log("You quit the game!");
        Application.Quit();    
    }
}
