using UnityEngine;
using System.Collections;

public class Destroyer7 : MonoBehaviour {
	
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			Application.LoadLevel(17);
			return;
		}
		
		if(other.gameObject.transform.parent)
		{
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy (other.gameObject);
		}
	}
}

