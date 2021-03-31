using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{

    public FinalScene roomScript;
    public CursourScript cursourScript;



    private void OnMouseDown()
    {
        roomScript.DisplayPoster();
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
