using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public string logText = "Hello World Again";
	public float speed = 2;
	// Use this for initialization
	void Start () {
		Debug.Log(logText);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(logText);
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

		rigidbody.velocity = Vector2.right * speed;
	}
}
