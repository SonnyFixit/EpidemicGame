using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy : MonoBehaviour
{

    public Transform player;
    public AIPath aiPath;
    public Transform startPoint;
    public DealDamage dealDamageScript;
    public GameObject toDestroy;

    private void Start()
    {
        aiPath.target = startPoint;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == player.name)
        {
            dealDamageScript.SendDamage(1);
        }
    }

    public void OnEnemyStartMove()
    {
        aiPath.target = player;
    }

    public void OnenemyEndMove()
    {
        aiPath.target = startPoint;
    }

    public void TakeDamage()
    {
        Object.Destroy(toDestroy);
    }
}
