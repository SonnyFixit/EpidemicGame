using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{
    public GameObject backdrop, endingScreen;
    public Button closeButton, enterGame;
    public TextMeshProUGUI text, enterGameText;
    public Image flowerImage, VRImage, rightBooks, leftBooks, headphones, poster, photo;
    public CursourScript cursourScript;
    public SpriteRenderer cursour;
    public Text ending1, ending2, ending3;
    int changed = 0;


    // Start is called before the first frame update
    void Start()
    {
        
        backdrop.SetActive(false);
        ending1.enabled = true;
        ending2.enabled = false;
        ending3.enabled = false;
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
        enterGame.onClick.AddListener(HandleEndGame);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            switch(changed)
            {

                case 0:
                    {
                        ending2.enabled = true;
                        changed++;
                        break;
                    }
                case 1:
                    {
                        ending3.enabled = true;
                        changed++;
                        break;
                    }
                case 2:
                    {
                        endingScreen.SetActive(false);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }

    public void DisplayFlower()
    {
        text.text = "Now that I'm looking at it... Maybe there's still some hope for this plant.";
        flowerImage.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayVR()
    {
        text.text = "I quit trying to get in there ever again. That'll probably be for the best.";
        VRImage.enabled = true;
        backdrop.SetActive(true);
        enterGame.enabled = true;
        enterGameText.enabled = true;
        hideCustomCursour();
    }

    public void DisplayRightBooks()
    {
        text.text = "Those weren't bad books after all. Maybe I'll seek for another part of the series?";
        rightBooks.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayLeftBooks()
    {
        text.text = "I think I'll take those to the basement tomorrow. This room could use general cleaning as well.";
        leftBooks.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayHeadphones()
    {

        text.text = "Oh, I like that song. I should listen to it more often.";
        headphones.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayPoster()
    {
        text.text = "That concert cancellation really was a shame. Though it's not like they are not going to perform live anymore, right?";
        poster.enabled = true;
        backdrop.SetActive(true);
        hideCustomCursour();
    }

    public void DisplayPhoto()
    {
        text.text = "I hope Roy will be better soon. Maybe I should try to prepare something for his return.";
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



    public void HandleEndGame()
    {
        SceneManager.LoadScene(0);
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
