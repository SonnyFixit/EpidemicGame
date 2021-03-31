using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksRight : MonoBehaviour
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
        roomScript.DisplayRightBooks();
        Debug.Log("Books right clicked");
    }

    private void OnMouseOver()
    {

        cursourScript.CoursourHover();
    }

    private void OnMouseExit()
    {
        cursourScript.CursourExit();

    }
}

