using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void LoadMenu()
    {
        score.scorePoints = 0;
        enemyShotScript.lost = false;
        SceneManager.LoadScene("MiniGame1");

    }

    public void QuitGame()
    {
        score.scorePoints = 0;
        enemyShotScript.lost = false;
        SceneManager.LoadScene("BarScene");
    }
}
