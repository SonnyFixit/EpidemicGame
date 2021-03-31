using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalHome : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D other)
    {

        // Podłoga w barze została podzielona na kilka części - kolizja z nimi powoduje przełączenie na ściśle określoną kamerę.

        if (other.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene(9);
        }




    }
}
