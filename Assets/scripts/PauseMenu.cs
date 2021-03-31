using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Czy gra jest zatrzymana
    public static bool GameIsPaused = false;
    //Panel pause menu
    public GameObject pauseMenuUI;

    private void Update()
    {
        //Włączenie/wyłączenie pause menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                Resume();
            else
                Pause();
        }
    }

    //Wznowienie gry
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //Zatrzymanie gry
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //Przeniesienie do menu głównego
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }

    //Wyjście z gry
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}