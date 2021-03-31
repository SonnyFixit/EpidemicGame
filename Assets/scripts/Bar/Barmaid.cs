using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barmaid : MonoBehaviour
{

    public Bar barScript;
    bool barmaidCollision = false;
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
        if (Input.GetKeyDown(KeyCode.F) && (barmaidCollision))
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
                        y = 12;
                    }

                else
                    {
                        x = 12;
                        y = 13;
                    }
            }


            else
            {
                if (talkedTo == 0)
                {
                    x = 13;
                    y = 18;
                }
                else
                {
                    x = 18;
                    y = 19;
                }
            }

           
                    
                  
            

            this.TriggerDialogue(x, y);
            barScript.StartBarmaidConversation();
            talkedTo++;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.name == "Player")
        {
        
            barScript.BarmaidActionStart();
            barmaidCollision = true;
        } 

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
         
            barScript.BarmaidActionFinish();
            barmaidCollision = false;
        }
    }

    public void TriggerDialogue(int x, int y)
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue, x, y);
    }
}

