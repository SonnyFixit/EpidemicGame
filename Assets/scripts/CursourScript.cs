using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursourScript : MonoBehaviour
{
    public SpriteRenderer standardCursour;
    public Sprite hoverCursour;
    public Sprite standardCursourSprite;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

    }

    public void CoursourHover()
    {
        standardCursour.sprite = hoverCursour;
    }

    public void CursourExit()
    {
        standardCursour.sprite = standardCursourSprite;
    }
}
