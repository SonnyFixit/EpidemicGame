using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class EndGamePanelScript : MonoBehaviour
{
    public Button tryAgainButton, backToBarButton;
    private static int levelScenNum = 8;
    private static int barSceneNum = 2;
    
    void Start()
    {
        tryAgainButton.onClick.AddListener(HandleTryAgain);
        backToBarButton.onClick.AddListener(HandleBackToBar);
    }

    private  void HandleTryAgain()
    {
         SceneManager.LoadScene(levelScenNum);
    }

    private void HandleBackToBar()
    {
        SceneManager.LoadScene(barSceneNum);
    }


}
