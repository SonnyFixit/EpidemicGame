using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SofaNPCs : MonoBehaviour
{

    public Bar barScript;
    bool sofaNPCsCollision = false;
    public Dialogues dialogue;
    public static int talkedTo;
    int progress;


    private void OnEnable()
    {
        //talkedTo = 0;
        progress = PlayerProgress.progress;
    }

    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.F) && (sofaNPCsCollision))
        {
            barScript.BarmaidActionFinish();
            int x;
            int y;
            // *** Choose dialogue depending on player progress
            // and the count of times player already spoke to the character in that scene

            if (progress == 0)
            {
                if (talkedTo == 0)
                {
                    x = 0;
                    y = 6;
                }
                else
                {
                    x = 5;
                    y = 6;
                }
            }
               

            else
            {
                if (talkedTo == 0)
                {
                    x = 6;
                    y = 9;
                }
                else
                {
                    x = 8;
                    y = 9;
                }
            }

            

            this.TriggerDialogue(x, y);
            barScript.StartBarmaidConversation();
            talkedTo++;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Player")
        {

            barScript.BarmaidActionStart();
            sofaNPCsCollision = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {

            barScript.BarmaidActionFinish();
            sofaNPCsCollision = false;
        }
    }

    public void TriggerDialogue(int x, int y)
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue, x, y);
    }
}


