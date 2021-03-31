using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer rend;

    public Material Material1;
    
    public GameObject Object;



    void Update()
    {
        if (GardenScript.virusDead == true)
        {
            
            {
                
                Object.GetComponent<SpriteRenderer>().material = Material1;
            }
            
        }
    }
}

