using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public string logText = "Hello World Again";
	public float speed = 2;
    public float health = 10;
    public float jumpSpeed = 50;

    // Use this for initialization
    void Start (){
		Debug.Log(logText);
        ApplyDamage(0);
	}
	
	// Update is called once per frame
	void Update () {
		
        //Getting the rigidbody from the game object we are attached to
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        //Number between -1 and 1 based on player pressing left or right
        float horizontal = Input.GetAxis("Horizontal");

        //Boolean (true or false) based on player pressing space bar
        bool jump = Input.GetButtonDown ("Jump");

        //Find out if we are touching the ground

        //Get the collider component attached to this object
        Collider2D collider = GetComponent<Collider2D>();

        //Find out if we are colliding with the ground
        LayerMask groundLayer = LayerMask.GetMask("Ground");

        bool touchingGround = collider.IsTouchingLayers(groundLayer);

        //Debug.Log(horizontal);

        //Cache a local copy of our rigidbody's velocity
        Vector2 velocity = rigidbody.velocity;

        //Set the x(left/right) component of the velocity on our input
        velocity.x = horizontal * speed;

        //Set the y (up/down) component of the velocioty based on jump
        if(jump == true && touchingGround == true)
        {
            velocity.y = jumpSpeed;

        }

        //Set our rigidbody's velocity based on our local copy
        rigidbody.velocity = velocity;

        //Print a log when the mouse button is presses
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("You pressed a button, good for you!");
        }

        //Print a log of the mouse position
        Vector2 mousePosition = Input.mousePosition;
        Debug.Log("Mouse position is" + mousePosition);
	}

    public void ApplyDamage (float damageToDeal)
    {
        health = health - damageToDeal;

    }
}
