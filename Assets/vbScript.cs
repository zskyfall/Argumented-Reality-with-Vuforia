using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour,IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject zoombie;
	private Animation anim;
	private AnimationClip clip = new AnimationClip();



	// Use this for initialization
	void Start () {
		clip.legacy = true;

		vbButtonObject = GameObject.Find ("actionButton");
		zoombie = GameObject.Find ("zoombie");

		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler(this);

		if (vbButtonObject) {
			Debug.Log ("Tim thay NUT!!!");

		} else {
			Debug.Log ("KHONG TIM THAY NUT");
		}

		

	}


	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		
		Debug.Log ("Bam nut");
		zoombie.GetComponent<Animation> ().Play ();
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("tha nut");

		zoombie.GetComponent<Animation> ().Play ("walk");
	}
}
