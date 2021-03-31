using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterDark : MonoBehaviour
{
    public Room roomScript;
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
