using UnityEngine;
using System.Collections;

public class speedboost : MonoBehaviour {

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			gameObject.renderer.enabled = false;
			Destroy (this.gameObject,2);
		}
	}
}