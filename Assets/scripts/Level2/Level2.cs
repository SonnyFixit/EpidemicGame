using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    public Transform playerStartPoint;
    public Transform player;
    public GameObject endGamePanel;
    public Button tryAgainButton;
    public Teleport teleportScript;


    void Start()
    {
        tryAgainButton.onClick.AddListener(HandleTryAgain);
        endGamePanel.SetActive(false);
        BackToStart();
    }

    public void BackToStart()
    {
        player.position = playerStartPoint.position;
    }

    public void handleEndGame()
    {
        Debug.Log("End game");
        endGamePanel.SetActive(true);
        //SceneManager.LoadScene(9);
        BackToStart();
        Time.timeScale = 0;
    }

    private void HandleTryAgain()
    {
        //Scene scene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(scene.name);
        
        endGamePanel.SetActive(false);
        teleportScript.ResetPlayer();
        Time.timeScale = 1;
    }



}
