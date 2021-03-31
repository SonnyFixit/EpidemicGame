using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private Transform playerPos;


    public Button backToBar, endGame;

    // Start is called before the first frame update
    void Start()
    {
        backToBar.onClick.AddListener(HandleBackToBar);
        playerPos = GameObject.Find("Player").transform;

    }

    void HandleBackToBar()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
}
