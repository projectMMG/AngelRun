using UnityEngine;
using System.Collections;

public class BGAction02 : MonoBehaviour {
	public float scrlSpeed = 0;
	//float oneSec = 0;
	
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
		
	}
	
	// Update is called once per frame
	void Update () {
		/*oneSec = Time.deltaTime;
		
		if(oneSec > 0.1f)
		{
			transform.Translate(-0.1f*scrlSpeed,0,0);
		}
		*/
		if(transform.position.x < -400.0f)
		{
			transform.position = new Vector2(395,0);
		}
		
	}
}
