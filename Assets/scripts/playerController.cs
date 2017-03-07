using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	private GameObject zoombie;
	private GameObject car;
	public float moveSpeed = 100f;
	// Use this for initialization
	void Start () {
		zoombie = GameObject.Find ("zoombie");
		car = GameObject.Find ("car");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Attack(){
		if (car) {
			
			//zoombie.transform.Translate (new Vector3(0,0,100));
			zoombie.transform.position = Vector3.MoveTowards(zoombie.transform.position,car.transform.position,100f);
			zoombie.GetComponent<Animation>().Play("attack");
		}

	}
	public void Walk(){
		zoombie.GetComponent<Animation>().Play("walk");
	}
	public void Fall(){
		zoombie.GetComponent<Animation>().Play("left_fall");
	}
}
