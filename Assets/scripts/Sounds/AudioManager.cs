using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public float musicVolume;

    //public static AudioManager instance;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("AudioVolume"))
        {
            musicVolume = PlayerPrefs.GetFloat("AudioVolume");
            audioSource.volume = musicVolume;
        }
        else
        {
            audioSource.volume = 0.5f;
        }
        
        
        
    }

    public void ChangeAudioVolume(float value)
    {
        audioSource.volume = value;
        Debug.Log("Audio volume: " + audioSource.volume);
        PlayerPrefs.SetFloat("AudioVolume", value);
    }

   
}
