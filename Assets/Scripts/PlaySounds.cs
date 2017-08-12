using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class PlaySounds : MonoBehaviour {

	public AudioClip impact;
		
	void OnTriggerEnter(Collider cc)
	{
	if(gameObject.tag == "coin")
		{
			AudioSource.PlayClipAtPoint (impact, gameObject.transform.position);
		}
	}
}
