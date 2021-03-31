using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour 
{
	public int health;
	public int maxHealth = 6;
	public Level2 level2Script;

	//Trzymanie obrażeń
	public void TakeDamage(int damage)
	{
		health -= damage;
		Debug.Log("Health = " + health.ToString());

		if(level2Script)
        {
			if (health <= 0)
			{
				//transform.position = new Vector2(-244f, 1.8f);
				level2Script.handleEndGame();
				//Time.timeScale = 0;		
			}
		}
		
		
	}

	//Odnowienie życia
	public void Heal(int heal)
	{
		if (health < maxHealth)
		{ 
			health += heal;
			Debug.Log("Health = " + health.ToString());
		}
	}
}
