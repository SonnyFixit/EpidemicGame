using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{

    public Text nameText, dialogueText;
    public Bar LocationScript;
    private Queue<string> dialogues;

    void Start()
    {
        dialogues = new Queue<string>();
    }

    public void StartDialogue(Dialogues dialogueLines, int x, int y)
    {
        //set active NPC name as name
        nameText.text = dialogueLines.npcName;

        //clear the dialogue queue
        dialogues.Clear();
        
        // Tutaj będzie sprawdzenie poziomu postępu w dialogach gracza
        // determine which sentences are going to be shown

        for (int i = x; i < y; i++)
        {
            dialogues.Enqueue(dialogueLines.dialogue[i]);
        }

        DisplayNext();


    }

    public void DisplayNext()
    {
        if (dialogues.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = dialogues.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        
        Debug.Log("End");
        LocationScript.CloseDialoguePanel();
        
    }
}
