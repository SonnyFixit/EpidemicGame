using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Teleport : MonoBehaviour
{
    public Inventory inventoryScript;
    public int nextLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
           
            bool result = inventoryScript.items.Find(x => x.itemName.Contains("Violet"));
            if(result || inventoryScript == null)
            {
                CharacterController2D player = collision.GetComponent<CharacterController2D>();                
                SceneManager.LoadScene(nextLevel);
                PlayerProgress.progress++;
                ResetPlayer();
                Debug.Log(PlayerProgress.progress);
            }
           
        }
    }

    public void ResetPlayer()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<Inventory>().items.Clear();
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().health = 6;
    }
}
