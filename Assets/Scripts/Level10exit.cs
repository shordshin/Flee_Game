using UnityEngine;
using System.Collections;

public class Level10exit : MonoBehaviour {
	
	HUDScript hud;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript>();
			hud.IncreaseScore(5000);
			Application.LoadLevel(25);
			return;
		}
		
		
	}
}
