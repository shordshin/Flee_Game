using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour
{
	public float maxSpeed = 10f;
	bool facingRight = true;
	public float coeffSpeedUp = 1.0f;
	
	Animator anim;
	
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 500f;
	
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		//transform.Translate(5f * Time.deltaTime, 0f, 0f);
		
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		
		anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);
		
		
		if (!grounded)
			return;
		
		float move = Input.GetAxis ("Horizontal");
		
		anim.SetFloat ("Speed", Mathf.Abs(move));
		
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);


	}
	
	void Update()
	{
		
		if (grounded && Input.GetKeyDown (KeyCode.Space)) 
		{
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
			
		}
	}
	
	public IEnumerator StopSpeedUp() {
		yield return new WaitForSeconds(2.5f); // the number corresponds to the number of seconds the speed up will be applied
		coeffSpeedUp = 1.0f; // back to normal !
	}
}