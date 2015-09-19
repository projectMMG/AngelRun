using UnityEngine;
using System.Collections;

public class TBulletAction : MonoBehaviour {
	public float scrlSpd;
	GameObject angel;
	
	// Use this for initialization
	void Start () {
		//초기설정
		transform.parent = GameObject.Find("03_Bullet").transform;
		//randPos = Random.Range(posMin, posMax); //randPos = Random.Range(5.1f, 46.0f);
		//transform.position = new Vector2(128.0f,50.0f);
		//rigidbody2D.velocity = new Vector2(-scrlSpeed,0);
		
	}
	
	void Update(){
		//화면 벗어나면 제거
		if(transform.position.y >= 72.0f)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
			transform.position = new Vector2(-10.0f,36.0f);
		}
	}
	
	//활성화
	void OnEnable()
	{
		angel = GameObject.Find("Angel01");
		lunchTBullet();
	}
	
	public void lunchTBullet()
	{
		float XDiffer = transform.position.x - angel.transform.position.x;
		float YDiffer = angel.transform.position.y - transform.position.y;
		
		float distance = Mathf.Sqrt((XDiffer*XDiffer)+(YDiffer*YDiffer));
		
		float XSpd = XDiffer / distance * scrlSpd;
		float YSpd = YDiffer / distance * scrlSpd;
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(-XSpd,YSpd);
	}
	
	
}
