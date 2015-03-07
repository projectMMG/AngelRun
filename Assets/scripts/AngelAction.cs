using UnityEngine;
using System.Collections;

public class AngelAction : MonoBehaviour {
	public float angelGravity = 1;
	public float velotest = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			if(rigidbody2D.velocity.y < 0)
			{
				rigidbody2D.velocity = new Vector2(0,0);
			}
			rigidbody2D.gravityScale = -angelGravity;
		}
		else
		{
			rigidbody2D.gravityScale = angelGravity;
		}
		velotest = rigidbody2D.velocity.y;
	
	}
}
