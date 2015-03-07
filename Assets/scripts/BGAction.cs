using UnityEngine;
using System.Collections;

public class BGAction : MonoBehaviour {
	public float scrlSpeed = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-0.01f*scrlSpeed,0,0);
		
		if(transform.localPosition.x < -20.0f)
		{
			transform.localPosition = new Vector3(20.0f,-0.5f,0);
		}
	
	}
}
