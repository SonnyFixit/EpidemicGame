using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    float speed = 3;
    [SerializeField] AudioSource explosionEffect;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        explosionEffect.Stop();
    }


    void Update()
    {
        if (transform.position.x >= 10)
        {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y - 1.5f);
            speed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        else if (transform.position.x <= -10)
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 1.5f);
            speed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
    }

    private void OnDestroy()
    {
        explosionEffect.Play();
    }
}
