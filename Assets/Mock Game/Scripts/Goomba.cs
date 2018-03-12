using UnityEngine;
using System.Collections;

public class Goomba : MonoBehaviour {
    public float damage = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision!");
        Player Mario = collision.collider.GetComponent<Player>();
        if (Mario != null)
        {
            Mario.ApplyDamage(damage);
        }
    }
}
