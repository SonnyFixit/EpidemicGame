using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Kamerą użytą do śledzenia gracza jest kamera z paczki Cinemachine.
//Wszystkie obrazki składające się na  daną scenę zostają umieszczone w jednym folderze/obiekcie. W tym przypadku jest to Garden. Innymi słowy - stają się dziećmi tego obiektu.
//Każdy z takich obrazków jest odpowiednio rozmieszczony na warstwach oraz osi Z. 
//Do każdego dziecka zostaje dodany skrypt ParallaxLayer, dzięki któremu można przypisać prędkość każdej warstwie.



public class Background : MonoBehaviour
{
    public ParallaxCamera parallaxCamera;
    
    List<ParallaxLayer> parallaxLayers = new List<ParallaxLayer>();

    void Start()
    {
       
        // Przypisanie głównej  kamery, jeżeli nie zostało to zrobione.
        if (parallaxCamera == null)
        {
            parallaxCamera = Camera.main.GetComponent<ParallaxCamera>();
        }


        if (parallaxCamera != null)
        {
            parallaxCamera.cameraMove += Move;
        }
        
        SetLayers();
    }

    void SetLayers()
    {
        //Ustawianie warstw. Początkowo lista jest czyszczona, a następnie zostają do niej dodane kolejne dzieci, ze zmienioną nazwą.

        parallaxLayers.Clear();
        
        for (int i = 0; i < transform.childCount; i++)
        {
            ParallaxLayer layer = transform.GetChild(i).GetComponent<ParallaxLayer>();

            if (layer != null)
            {
                layer.name = "Layer-" + i;
                parallaxLayers.Add(layer);
            }
        }
    }

    //Wywołanie metody dla każdej z warstw będącej dzieckiem oraz modyfikacja jej pozycji o wartość ruchu kamery.

    void Move(float delta)
    {
        
        
        foreach (ParallaxLayer layer in parallaxLayers)
        {
            layer.Move(delta);
        }
    }
}

