using UnityEngine;
using System.Collections;


public class ExecutionerControl : MonoBehaviour {
	
	public float runSpeed = 2.0f;
	public float runLeft = 0.0f;
	public float runRight = 5.0f;
	
	float runningDirection = 1.0f;
	Vector3 runAmount;
	
	// Update is called once per frame
	void Update () {
		
		runAmount.x = runningDirection * runSpeed * Time.deltaTime;
		
		if (runningDirection > 0.0f && transform.position.x >= runRight)
			runningDirection = -1.0f;
		else if (runningDirection < 0.0f && transform.position.x <= runLeft)
			runningDirection = 1.0f;
		
		transform.Translate(runAmount);
	}
}