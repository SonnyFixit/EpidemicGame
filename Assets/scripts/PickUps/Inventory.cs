using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public GameObject[] slots;

    private void Update()
    {
        slots = GameObject.FindGameObjectsWithTag("Slot");
        DisplayItems();
    }

    //Wyświetlenie przedmiotów
    public void DisplayItems()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < items.Count)
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

            }
            else 
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
            }
        }
    }

    //Dodanie przedmiotu do ekwipunku
    public void AddItem(Item _item)
    {
        if (!items.Contains(_item))
        {
            items.Add(_item);
        }
        DisplayItems();
    }
}
