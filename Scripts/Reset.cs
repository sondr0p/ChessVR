using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
	public Vector3 myPos;
	public Quaternion myRotation;
	
	// Use this for initialization
	void Start () {
		myPos = this.transform.position;
		myRotation = this.transform.rotation;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetDown(OVRInput.Button.Four)){
			this.transform.position = myPos;
			this.transform.rotation = myRotation;
		}
		
	}
}
