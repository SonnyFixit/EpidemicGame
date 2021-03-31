using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParallaxLayer : MonoBehaviour
{
    public float parallaxChangeValue;
    

    //Metoda modyfikuje pozycję każdej z warstw o podaną w inspektorze wartość.
    //Wartość 1 sprawia, że warstwa porusza się z prędkością identyczną do prędkości kamery. 2 - dwa razy szybciej. 0.1 - 1/10 prędkości kamery.
    
    public void Move(float delta)
    {
        Vector3 newPos = transform.localPosition;
        newPos.x -= delta * parallaxChangeValue;
        transform.localPosition = newPos;
    }
}
