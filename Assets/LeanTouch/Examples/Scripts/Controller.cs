using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	private GameObject zoombie;
	private Button btnAttack;
	// Use this for initialization
	void Start () {
		zoombie = GameObject.Find ("zoombie");

	}

	public void danh(){
		zoombie.GetComponent<Animation> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
