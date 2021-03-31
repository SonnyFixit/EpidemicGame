using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    public Level2 level2Script;
    public DealDamage dealDamageScript;
    
   

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            level2Script.BackToStart();
            dealDamageScript.SendDamage(1);
        }
    }
}
