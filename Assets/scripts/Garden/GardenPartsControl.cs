using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenPartsControl : MonoBehaviour
{

    public GameObject firstPart;
    public GameObject secondPart;

    // Start is called before the first frame update
    void Start()
    {

        //firstPart.SetActive(true);
        //secondPart.SetActive(false);


    }

    public void OnCollisionEnter2D(Collision2D other)
    {

        // Podłoga w barze została podzielona na kilka części - kolizja z nimi powoduje przełączenie na ściśle określoną kamerę.

        if (other.gameObject.tag == "GardenFloor1")

        {
            //firstPart.SetActive(true);
            //secondPart.SetActive(false);
        }


        if (other.gameObject.tag == "GardenFloor2")

        {
            //firstPart.SetActive(false);
            //secondPart.SetActive(true);
        }
    }
}
