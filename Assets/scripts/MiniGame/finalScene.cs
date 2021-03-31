using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalScene : MonoBehaviour
{
    [SerializeField] GameObject aliens;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (enemyShotScript.lost || aliens.GetComponentInChildren<Rigidbody2D>() == null)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("MiniGame3");
        }
    }
}
