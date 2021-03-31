using UnityEngine;
using System.Collections;
using System; 
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SaveAndLoad : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        //Postać gracza
        player = GameObject.FindGameObjectWithTag("Player");
    }

    //Szybki zapis i załadowanie gry
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            SaveGame();
        }

        if (Input.GetKeyDown(KeyCode.F10))
        {
            LoadGame();
        }
    }

    //Zapis
    public void SaveGame()
    {
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.data");

        PlayerData data = new PlayerData();
        data.sceneName = SceneManager.GetActiveScene().name;
        data.progress = PlayerProgress.progress;

        BinaryFormatter bf = new BinaryFormatter();

        bf.Serialize(file, data);

        file.Close();
        Debug.Log("save");
    }

    //Ładowanie zapisu
    public void LoadGame()
    {
        Debug.Log("load");
        BinaryFormatter bf = new BinaryFormatter();

        if (File.Exists(Application.persistentDataPath + "/playerInfo.data"))
        {

            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.data", FileMode.Open);
            
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            SceneManager.LoadScene(data.sceneName);
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<Inventory>().items.Clear();
            PlayerProgress.progress = data.progress;
            Debug.Log("load");
        }
    }

}

//Klasa do zapisu
[Serializable]
class PlayerData
{
    public String sceneName;
    public int progress;
}
