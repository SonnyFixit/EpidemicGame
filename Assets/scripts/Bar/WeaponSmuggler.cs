using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSmuggler : MonoBehaviour
{

    public Bar barScript;
    bool smugglerCollision = false;
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
        if (Input.GetKeyDown(KeyCode.F) && (smugglerCollision))
        {
            barScript.WeaponSmugglerActionStart();
            int x;
            int y;

            if (Barmaid.talkedTo == 0 && progress == 0)
            {
                    x = 0;
                    y = 1;
                
            }


            else if (talkedTo == 0  && progress == 0)
            {

                    x = 1;
                    y = 8;

                talkedTo++;

                
            }
            else
            {
                    x = 8;
                    y = 9;
            }

            this.TriggerDialogue(x, y);
            barScript.StartBarmaidConversation();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Player")
        {

            barScript.WeaponSmugglerActionStart();
            smugglerCollision = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {

            barScript.WeaponSmugglerActionFinish();
            smugglerCollision = false;
        }
    }

    public void TriggerDialogue(int x, int y)
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue, x, y);
    }
}
