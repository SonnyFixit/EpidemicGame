using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName ="item", fileName ="New item")]
//Informacje o przedmiocie
public class Item : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;
}
