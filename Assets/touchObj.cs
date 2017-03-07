﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){ // if left button pressed...
			Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if(hit.collider.tag == "arObj")
				{
					GameObject obj=GameObject.FindGameObjectWithTag("arObj");
					Debug.Log ("Da click");
				}
			}
		}
	}
}
