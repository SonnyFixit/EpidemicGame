using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR : MonoBehaviour
{
    public Bar barScript;
    bool enterLevelCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && (enterLevelCollision))
        {
            barScript.LevelActionFinish();
            barScript.StartLevelInteraction();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Player")
        {

            barScript.LevelActionStart();
            enterLevelCollision = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {

            barScript.LevelActionFinish();
            enterLevelCollision = false;
        }
    }

}
