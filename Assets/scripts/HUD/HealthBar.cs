using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //HealthBar
    public Image[] healthImgs;
    //Aktualny poziom życia gracza
    PlayerHealth playerHealth;
    int health;

    private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        health = playerHealth.health;
        
        //Aktualizacja HealthBar'a w zależności od poziomu życia
        switch (health)
        {
            case 6:
                foreach (Image img in healthImgs)
                {
                    img.gameObject.SetActive(true);
                }
                break;

            case 5:
                healthImgs[0].gameObject.SetActive(true);
                healthImgs[1].gameObject.SetActive(true);
                healthImgs[2].gameObject.SetActive(true);
                healthImgs[3].gameObject.SetActive(true);
                healthImgs[4].gameObject.SetActive(true);
                healthImgs[5].gameObject.SetActive(false);
                break;

            case 4:
                healthImgs[0].gameObject.SetActive(true);
                healthImgs[1].gameObject.SetActive(true);
                healthImgs[2].gameObject.SetActive(true);
                healthImgs[3].gameObject.SetActive(true);
                healthImgs[4].gameObject.SetActive(false);
                healthImgs[5].gameObject.SetActive(false);
                break;

            case 3:
                healthImgs[0].gameObject.SetActive(true);
                healthImgs[1].gameObject.SetActive(true);
                healthImgs[2].gameObject.SetActive(true);
                healthImgs[3].gameObject.SetActive(false);
                healthImgs[4].gameObject.SetActive(false);
                healthImgs[5].gameObject.SetActive(false);
                break;

            case 2:
                healthImgs[0].gameObject.SetActive(true);
                healthImgs[1].gameObject.SetActive(true);
                healthImgs[2].gameObject.SetActive(false);
                healthImgs[3].gameObject.SetActive(false);
                healthImgs[4].gameObject.SetActive(false);
                healthImgs[5].gameObject.SetActive(false);
                break;

            case 1:
                healthImgs[0].gameObject.SetActive(true);
                healthImgs[1].gameObject.SetActive(false);
                healthImgs[2].gameObject.SetActive(false);
                healthImgs[3].gameObject.SetActive(false);
                healthImgs[4].gameObject.SetActive(false);
                healthImgs[5].gameObject.SetActive(false);
                break;

            case 0:
                healthImgs[0].gameObject.SetActive(false);
                healthImgs[1].gameObject.SetActive(false);
                healthImgs[2].gameObject.SetActive(false);
                healthImgs[3].gameObject.SetActive(false);
                healthImgs[4].gameObject.SetActive(false);
                healthImgs[5].gameObject.SetActive(false);

                Debug.Log("Player dead");
                break;
        
        }
    }
}
