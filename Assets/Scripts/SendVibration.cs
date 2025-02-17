using UnityEngine;
using System.Collections;

public class SendVibration : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	 void OnMouseDown() {
	 	print("Clicked");
	 	Sending.sendVibration();
		this.GetComponent<AudioSource>().Play();
	 }
/*	void OnMouseUp() {
		print("Releas");
		Sending.sendLowVibration();

	}*/
}
