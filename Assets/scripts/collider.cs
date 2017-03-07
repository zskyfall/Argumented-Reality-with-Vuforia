using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {
	
	private GameObject zoombie;
	public float moveSpeed = 20f;
	public float turnSpeed = 20f;
	public Animator anim;
	// Use this for initialization
	void Start () {
		zoombie = GameObject.Find ("zoombie");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			this.GetComponent<Animation> ().Play ("walk");
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			this.GetComponent<Animation> ().Play ("walk");
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
			this.GetComponent<Animation> ().Play ("walk");
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate (-Vector3.up * turnSpeed * Time.deltaTime);
			this.GetComponent<Animation> ().Play ("walk");
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "zoombie") {
			Destroy (col.gameObject);
		} else {
			Debug.Log (col.gameObject.name);
			Debug.Log ("DA DUNG NHAU");
		}
	}


}
