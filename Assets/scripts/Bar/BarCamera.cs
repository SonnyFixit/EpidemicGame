using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BarCamera : MonoBehaviour
{
    //Kamery, które pojawiają się na scenie z barem
    //Skrypt jest przypisany do gracza, więc to w nim trzeba ustawić wszystkie te kamery
    //Całość jest skuteczna, ale też raczej prosta od strony algorytmu. Wypada jednak rozważyć czy chcecie wielokrotnych przynosin do baru.
    //Jeżeli tak - za każdym razem należało przypisać do prefaba ten skrypt (oraz drugi, z muzyką), żeby całość działała.


    public Camera firstCamera;
    public Camera secondCamera;
    public Camera thirdCamera;
    public Camera fourthCamera;
    public Camera fifthCamera;
    public Camera sixhtCamera;
    public Camera seventhCamera;



    private void Start()
    {
        //Na starcie aktywna jest tylko kamera w miejscu, w którym pojawia się gracz. Reszta jest wyłączona.

        firstCamera.enabled = false;
        secondCamera.enabled = false;
        thirdCamera.enabled = false;
        fourthCamera.enabled = true;
        fifthCamera.enabled = false;
        sixhtCamera.enabled = false;
        seventhCamera.enabled = false;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        
        // Podłoga w barze została podzielona na kilka części - kolizja z nimi powoduje przełączenie na ściśle określoną kamerę.

        if (other.gameObject.tag == "FloorArcade")

        {
            firstCamera.enabled = true;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
            fifthCamera.enabled = false;
            sixhtCamera.enabled = false;
            seventhCamera.enabled = false;
        }

        if (other.gameObject.tag == "FloorBar")

        {
            firstCamera.enabled = false;
            secondCamera.enabled = true;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
            fifthCamera.enabled = false;
            sixhtCamera.enabled = false;
            seventhCamera.enabled = false;
        }

        if (other.gameObject.tag == "FloorBar2")
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = true;
            fourthCamera.enabled = false;
            fifthCamera.enabled = false;
            sixhtCamera.enabled = false;
            seventhCamera.enabled = false;
        }

        if (other.gameObject.tag == "FloorBar3")
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = true;
            fifthCamera.enabled = false;
            sixhtCamera.enabled = false;
            seventhCamera.enabled = false;

            
        }

        if (other.gameObject.tag == "FloorBar4")
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
            fifthCamera.enabled = true;
            sixhtCamera.enabled = false;
            seventhCamera.enabled = false;

            
        }

        if (other.gameObject.tag == "FloorPortal1")
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
            fifthCamera.enabled = false;
            sixhtCamera.enabled = true;
            seventhCamera.enabled = false; 
        }

        if (other.gameObject.tag == "FloorPortal2")
        {
            firstCamera.enabled = false;
            secondCamera.enabled = false;
            thirdCamera.enabled = false;
            fourthCamera.enabled = false;
            fifthCamera.enabled = false;
            sixhtCamera.enabled = false;
            seventhCamera.enabled = true;

        }


    }
  

   
}
