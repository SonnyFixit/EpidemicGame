using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShotScript : MonoBehaviour
{
    float speed = -3f;
    public static bool lost = false;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            lost = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.tag == "Base")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
