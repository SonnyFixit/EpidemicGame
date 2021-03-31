using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMusic : MonoBehaviour
{

    //Podobnie jak w przypadku kamer - muzykę należy umieścić w postaci z gracze, razem z odpowiednimi Audio Sourcami.

    public AudioSource ArcadeSound;
    public AudioSource BarSound;


    //Na scenie są umieszczone 2 triggery - jeden pokrywa część arcade'a, jeden pokrywa wszystkie pozostałe.
    //Kiedy gracz się znajdzie w którymś z nich, odpalana jest odpowiednia muzyka.

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ArcadeSector")
        {
            ArcadeSound.Play();
            BarSound.Stop();
        }

        if (other.gameObject.tag == "BarSector")
        {
            ArcadeSound.Stop();
            BarSound.Play();
        }
    }



}
