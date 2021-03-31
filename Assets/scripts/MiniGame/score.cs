using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scorePoints;
    [SerializeField] Text scoreText;

    public static void updateScore(string enemyTag)
    {
        if (enemyTag == "Enemy1")
        {
            scorePoints += 10;
        }
        else if (enemyTag == "Enemy2")
        {
            scorePoints += 20;
        }
        else if (enemyTag == "Enemy3")
        {
            scorePoints += 30;
        }
    }

    private void LateUpdate()
    {
        scoreText.text = "Score: " + scorePoints;
    }
}
