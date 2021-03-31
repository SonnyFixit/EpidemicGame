using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    //domyślna wartość leczenia
    public int heal=1;

    //Zniszczenie obiektu
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SendHeal(heal);
        }
        Destroy(gameObject);
    }

    //Uleczenie gracza
    public void SendHeal(int heal)
	{
		PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerStats.Heal(heal);
	}
}
