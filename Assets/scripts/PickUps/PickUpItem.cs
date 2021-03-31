using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Item itemData;

    //Zniszczenie obiektu karty i dodanie go do listy zebranych przedmiotów
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);

            GameObject.FindGameObjectWithTag("GameManager").GetComponent<Inventory>().AddItem(itemData);
        }

    }
}
