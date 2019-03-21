using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {
	private Collider c;
	private OVRGrabbable ovrgrabbable;
	
	// Use this for initialization
	void Start () {
		ovrgrabbable = this.GetComponent<OVRGrabbable>();
		c = this.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log(ovrgrabbable.isGrabbed);
		if(ovrgrabbable.isGrabbed){
			c.isTrigger = true;
			if (OVRInput.GetDown(OVRInput.Button.One)){
				
			}
		}else{
			c.isTrigger = false;
		}
	}
}
