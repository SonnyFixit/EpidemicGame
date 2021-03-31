using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public FinalScene roomScript;
    public CursourScript cursourScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        roomScript.DisplayFlower();
        Debug.Log("Flower clicked");
    }

    private void OnMouseOver()
    {
        Debug.Log("flower hover");
        cursourScript.CoursourHover();
    }

    private void OnMouseExit()
    {
        cursourScript.CursourExit();
        Debug.Log("flower exit");
    }
}
