using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    public Bar barScript;
    bool minigameCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && (minigameCollision))
        {

            barScript.MiniGameActionFinish();
            barScript.StartGameInteraction();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Player")
        {

            barScript.MiniGameActionStart();
            minigameCollision = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {

            barScript.MiniGameActionFinish();
            minigameCollision = false;
        }
    }
}
