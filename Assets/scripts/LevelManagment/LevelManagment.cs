using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagment : MonoBehaviour
{
    public Button loadGame, newGame, back;
    // Start is called before the first frame update
    void Start()
    {
        loadGame.onClick.AddListener(onGameLoad);
        newGame.onClick.AddListener(onNewGame);
        back.onClick.AddListener(onGoBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onGameLoad()
    {
        SceneManager.LoadScene(7);
    }

    private void onNewGame()
    {
        SceneManager.LoadScene(7);
    }

    private void onGoBack()
    {
        SceneManager.LoadScene(5);
    }
}
