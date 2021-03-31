using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotScript : MonoBehaviour
{
    float speed = 8f;


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
        if (collision.tag == "Enemy1" || collision.tag == "Enemy2" || collision.tag == "Enemy3")
        {
            Destroy(collision.gameObject);
            score.updateScore(collision.gameObject.tag);
            Destroy(gameObject);
        }
        else if (collision.tag == "Base")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
