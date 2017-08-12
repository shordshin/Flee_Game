using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {
	
	public float maxSpeed = 5.0f;
	public float distance = 5.0f;
	float origX;
	//bool facingRight = true;
	
	// Use this for initialization
	void Start ()
	{
		//Vector3 origPosition = transform.position;
		origX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//float move = Input.GetAxis ("Horizontal");
		transform.Translate(maxSpeed*Time.deltaTime,0,0);
		
		if(Mathf.Abs(origX - transform.position.x) > distance)
		{
			maxSpeed *= -1.0f;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;//change direction
		}

		//if (move > 0 * *!facingRight)
				//		Flip ();
				//else if (move < 0 && facingRight)
				//		Flip ();
	}

	//void Flip()
	//{
	//	facingRight = !facingRight;
	//	Vector3 theScale = transform.localScale;
	//	theScale.x *= -1;
	//	transform.localScale = theScale
	//}
}