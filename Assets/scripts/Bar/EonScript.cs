using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EonScript : MonoBehaviour
{
    public Bar barScript;
    bool EonCollission = false;
    public Dialogues dialogue;
    public static int talkedTo;
    int progress;


    private void OnEnable()
    {
        //talkedTo = 0;
        progress = PlayerProgress.progress;
        if (progress > 0)
        {
            this.gameObject.SetActive(true);
        }

        else
        {
            this.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && (EonCollission))
        {
            barScript.EonActionFinish();
            int x;
            int y;

            // *** Choose dialogue depending on player progress
            // and the count of times player already spoke to the character in that scene


                    if (talkedTo == 0)
                    {
                        x = 0;
                        y = 9;
                    }
                    else
                    {
                        x = 9;
                        y = 10;
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
            if (talkedTo == 0)
            {
                barScript.EonActionFinish();
                EonCollission = true;
                this.TriggerDialogue(0, 9);
                barScript.StartBarmaidConversation();
                talkedTo++;
            }

            else
            {   
                 barScript.EonActionStart();
                 EonCollission = true;                
            }
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {

            barScript.EonActionFinish();
            EonCollission = false;
        }
    }

    public void TriggerDialogue(int x, int y)
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue, x, y);
    }
}
