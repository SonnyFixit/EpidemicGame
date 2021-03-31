using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParallaxCamera : MonoBehaviour
{
    
    private float lastPosition;

    public delegate void ParallaxCameraDelegate(float deltaMovement);

    public ParallaxCameraDelegate cameraMove;


    void Start()
    {
        //Zapisanie pozycji kamery w momencie startu sceny.

        lastPosition = transform.position.x;
    }
    void Update()
    {
        //Sprawdzanie aktualnej pozycji kamery oraz modyfikowanie jej o określoną wartość.

        if (transform.position.x != lastPosition)
        {
            if (cameraMove != null)
            {
                float delta = lastPosition - transform.position.x;
                cameraMove(delta);
            }
            

            //Zapisanie pozycji kamery już po modyfikacji.
            lastPosition = transform.position.x;
        }
    }
}

