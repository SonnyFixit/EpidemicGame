using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour
{

    public GameObject barmaidModal, smugglerModal, gameModal, levelModal, EonModal;
    public GameObject dialogueModal;
    public GameObject npcDialogue, minigameDialogue, enterVRDialogue, nonNPCdialogue;
    public bool isConversation = false;
    public Button endConversationButton, playMiniGameButton, loadLevelButton, nextDialogueButton;
    public Text  dialogueText, miniGameButtonText, loadLevelText, exitText, nextDialogueText;

    void Start()
    {
        
        barmaidModal.SetActive(false);
        smugglerModal.SetActive(false);
        gameModal.SetActive(false);
        EonModal.SetActive(false);
        levelModal.SetActive(false);
        dialogueModal.SetActive(false);
        endConversationButton.onClick.AddListener(CloseDialoguePanel);
        playMiniGameButton.onClick.AddListener(PlayMiniGame);
        loadLevelButton.onClick.AddListener(LevelLoad);
        npcDialogue.SetActive(false);
        nonNPCdialogue.SetActive(false);
        minigameDialogue.SetActive(false);
        enterVRDialogue.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // *** ON TRIGGER MESSAGES *** 
    public void BarmaidActionStart()
    {
        barmaidModal.SetActive(true);
    
    }

    public void WeaponSmugglerActionStart()
    {
        smugglerModal.SetActive(true);

    }

    public void MiniGameActionStart()
    {
        gameModal.SetActive(true);
     
    }

    public void EonActionStart()
    {
        EonModal.SetActive(true);

    }

    public void LevelActionStart()
    {
        levelModal.SetActive(true);
    }

    public void BarmaidActionFinish()
    {
        barmaidModal.SetActive(false);
    }


    public void WeaponSmugglerActionFinish()
    {
        smugglerModal.SetActive(false);

    }

        public void MiniGameActionFinish()
    {
        gameModal.SetActive(false);
    }

    public void EonActionFinish()
    {
        EonModal.SetActive(false);

    }

    public void LevelActionFinish()
    {
        levelModal.SetActive(false);
    }

    // *** INTERACTIONS ***

    public void StartBarmaidConversation()
    {
        dialogueModal.SetActive(true);
        npcDialogue.SetActive(true);
        nextDialogueButton.Select();
        isConversation = true;
    }

    public void StartSmugglerConversation()
    {
        dialogueModal.SetActive(true);
        npcDialogue.SetActive(true);
        isConversation = true; 

    }

    public void StartGameInteraction()
    {
        dialogueModal.SetActive(true);
        isConversation = true;
        nonNPCdialogue.SetActive(true);
        minigameDialogue.SetActive(true);
        playMiniGameButton.Select();

    }

    public void StartLevelInteraction()
    {
        dialogueModal.SetActive(true);
        isConversation = true;
        nonNPCdialogue.SetActive(true);
        enterVRDialogue.SetActive(true);
        loadLevelButton.Select();      
    }

  

    public void CloseDialoguePanel()
    {
        dialogueModal.SetActive(false);
        isConversation = false;
        npcDialogue.SetActive(false);
        enterVRDialogue.SetActive(false);
        minigameDialogue.SetActive(false);
        nonNPCdialogue.SetActive(false);
    }

    private void PlayMiniGame()
    {
        SceneManager.LoadScene(6);
        
    }

    public void LevelLoad()
    {
        int x;

        EonScript.talkedTo = 0;
        SofaNPCs.talkedTo = 0;
        Barmaid.talkedTo = 0;
        WeaponSmuggler.talkedTo = 0;

        if (PlayerProgress.progress == 0)
        {
            x = 3;
        }
        else
        {
            x = 10; 
        }
        SceneManager.LoadScene(x);
        
    }

}
