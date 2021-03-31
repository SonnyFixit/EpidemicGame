using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControl : MonoBehaviour
{
    float speed = 10;
    float maxBound = 10, minBound = -10;
    Transform player;
    [SerializeField] GameObject shot;
    [SerializeField] GameObject barrel;

    [SerializeField] AudioSource shotEffect;

    void Start()
    {
        player = GetComponent<Transform>();
        shotEffect.Stop();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        if (player.position.x < minBound && move < 0)
        {
            move = 0;
        }
        else if (player.position.x > maxBound && move > 0)
        {
            move = 0;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, 0);



        if (Input.GetKeyDown(KeyCode.Space) && Time.timeScale != 0)
        {
            shotEffect.Play();
            Instantiate(shot, barrel.transform.position, Quaternion.identity);
        }
    }
}