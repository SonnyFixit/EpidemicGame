using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Room : MonoBehaviour
{

    public GameObject backdrop;
    public Button closeButton, enterGame;
    public TextMeshProUGUI text, enterGameText;
    public Image flowerImage, VRImage, rightBooks, leftBooks, headphones, poster, photo;
    public CursourScript cursourScript;
    public SpriteRenderer cursour;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        backdrop.SetActive(false);
        flowerImage.enabled = false;
        VRImage.enabled = false;
        rightBooks.enabled = false;
        leftBooks.enabled = false;
        headphones.enabled = false;
        enterGame.enabled = false;
        poster.enabled = false;
        photo.enabled = false;
        enterGameText.enabled = false;
        closeButton.onClick.AddListener(CloseModal);
        enterGame.onClick.AddListener(HandleEnterGame);
    }


    public void DisplayFlower()
    {
        text.text = "I think, I should water my flowers. Though I think it's too late for them to revive.";
        flowerImage.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayVR()
    {
        text.text = "Oh yeah, I got that invitation for a new server some time ago. I can as well give it a try, I don't have anything to do anyway.";
        VRImage.enabled = true;
        backdrop.SetActive(true);
        enterGame.enabled = true;
        enterGameText.enabled = true;
        hideCustomCursour();
    }

    public void DisplayRightBooks()
    {
        text.text = "One positive thing about all this mess, huh? Finally got the time to read them. Three times already. Now I’m beginning to believe I’ve memorized all of them. ";
        rightBooks.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayLeftBooks()
    {
        text.text = "Nope, I'm not going to read those yet another time.";
        leftBooks.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayHeadphones()
    {
        
        text.text = "\"Welcome to News of the Day. According to the latest government data, twenty-three thousand new victims of the epidemic have been diagnosed today alone. The number of dead rose to...\" Not going to listen to that again.";
        headphones.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayPoster()
    {
        text.text = "The concert would be beginning around now. Well. At least I got a refund for my tickets. I don’t even want to think about it right now.";
        poster.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayPhoto()
    {
        text.text = "That was a nice birthday gift. I miss Roy. Hope he’ll recover soon. I’d really like to pay him a visit in the hospital.";
        photo.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void CloseModal()
    {
        backdrop.SetActive(false);
        flowerImage.enabled = false;
        VRImage.enabled = false;
        rightBooks.enabled = false;
        leftBooks.enabled = false;
        headphones.enabled = false;
        poster.enabled = false;
        photo.enabled = false;
        enterGame.enabled = false;
        enterGameText.enabled = false;
        showCustomCursour();
    }



    public void HandleEnterGame()
    {
        Debug.Log("Enter game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void hideCustomCursour()
    {
        cursour.enabled = false;
        Cursor.visible = true;
    }

    void showCustomCursour()
    {
        cursour.enabled = true;
        Cursor.visible = false;
    }
}
