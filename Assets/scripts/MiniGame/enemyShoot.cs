using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    float random;
    [SerializeField] GameObject shotEnemy;

    [SerializeField] AudioSource shotEffect;

    void Start()
    {
        shotEffect.Stop();
    }

    void Update()
    {
        random = Random.Range(1f, 1000f);
        if (random <= 2 && Time.timeScale != 0)
        {
            shotEffect.Play();
            Instantiate(shotEnemy, transform.position, Quaternion.identity);
        }
    }
}
