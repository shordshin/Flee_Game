using UnityEngine;
using System.Collections;

public class coinSmall : MonoBehaviour {

	HUDScript hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript>();
			gameObject.renderer.enabled = false;
			hud.IncreaseScore(100);
			Destroy (this.gameObject,2);
		}
	}
}