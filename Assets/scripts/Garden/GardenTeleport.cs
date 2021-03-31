using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenTeleport : MonoBehaviour
{
	public GameObject Player;
	public GameObject Portal;



	public void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Player.transform.position = new Vector2(Portal.transform.position.x, -4.46306f);
		}
	}

}



