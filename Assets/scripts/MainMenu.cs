using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public Slider musicVolume;
    public AudioManager audioManager;
    public Button loadButton;

    private void Start()
    {
        musicVolume.onValueChanged.AddListener(delegate { HandleMusicChange(); });
        musicVolume.value = audioManager.musicVolume;

        //Sprawdzenie czy istnieje plik z danymi do załadowania
        if (!File.Exists(Application.persistentDataPath + "/playerInfo.data"))
        {
            loadButton.enabled = false;
        }
        else
        {
            loadButton.enabled = true;
        }
    }

    //Załadowanie sceny pokoju
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Wyjście z gry
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    //Zmiana poziomu głośności muzyki
    private void HandleMusicChange()
    {
        Debug.Log("Music volume: " + musicVolume.value);
        audioManager.ChangeAudioVolume(musicVolume.value);
    }
}
