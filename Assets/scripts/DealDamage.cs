using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour 
{
	//Wysłanie otrzymanych obrażeń
	public void SendDamage (int dam)
	{
		PlayerHealth playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerStats.TakeDamage(dam);
	}
}
