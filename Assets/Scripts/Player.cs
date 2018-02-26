using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public string logText = "Hello World Again";
	public float speed = 2;
    public float health = 10;
	// Use this for initialization
	void Start (){
		Debug.Log(logText);
        ApplyDamage(0);
	}
	
	// Update is called once per frame
	void Update () {
		
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

		rigidbody.velocity = Vector2.right * speed;
	}

    public void ApplyDamage (float damageToDeal)
    {
        health = health - damageToDeal;

    }
}
