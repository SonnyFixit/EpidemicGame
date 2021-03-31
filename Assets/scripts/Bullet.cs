using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20;
    public Rigidbody2D rb;
    void Start()
    {
        
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);


        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {

            enemy.TakeDamage();
        }

        Destroy(gameObject);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Enemy enemy = collision.collider.GetComponent<Enemy>();
    //    Debug.Log(collision.collider.name);

    //    if (enemy != null)
    //    {
    //        enemy.TakeDamage();
    //    }

    //    Destroy(gameObject);
    //}


}
