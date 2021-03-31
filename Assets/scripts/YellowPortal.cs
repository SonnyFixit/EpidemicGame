using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPortal : MonoBehaviour
{
    public Transform yellowPortalEnd;
    public Inventory inventoryScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            bool result = inventoryScript.items.Find(x => x.itemName.Contains("Yellow"));
            
            if(result || inventoryScript == null)
            {
                Debug.Log("contains");

                collision.transform.position = yellowPortalEnd.transform.position;
            }
        }
    }
}
