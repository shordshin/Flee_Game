using UnityEngine;
using System.Collections;

public class coinBig : MonoBehaviour {
	
	HUDScript hud;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript>();
			gameObject.renderer.enabled = false;
			hud.IncreaseScore(500);
			Destroy (this.gameObject,2);
		}
	}
}