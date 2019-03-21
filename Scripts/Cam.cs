using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
	/* public Camera player;
	public Camera over; */
	
    public Camera FirstPersonCam, ThirdPersonCam;
	public bool camSwitch = false;
	// Use this for initialization
	void Start () {
		/* player.enabled = true;
		over.enabled = false; */
	}
	
	// Update is called once per frame
	void Update () {
		/* if(OVRInput.GetDown(OVRInput.Button.One)){
			player.enabled = false;
			over.enabled = true;
		}else{
			player.enabled = true;
			over.enabled = false;
		} */
		
		if(OVRInput.GetDown(OVRInput.Button.One)){
             camSwitch = !camSwitch;
             FirstPersonCam.gameObject.SetActive(camSwitch);
             ThirdPersonCam.gameObject.SetActive(!camSwitch);
        }
	}
}
