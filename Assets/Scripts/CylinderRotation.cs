using UnityEngine;
using System.Collections;

public class CylinderRotation : MonoBehaviour {

	protected Vector3 axis;

	// Use this for initialization
	void Start () {
	
		axis = new Vector3 (0,1f,0);
	}
	
	// Update is called once per frame
	void Update () {
	
		//transform.RotateAround ( GameObject.Find ("First Person Controller").transform.position, axis, (Sending.pitch - / 60);
		transform.RotateAround ( GameObject.Find ("3rd Person Controller").transform.position, axis, Sending.roll/90);
		//Debug.Log ("posicion: "+GameObject.Find ("CrossHair").transform.position);
		//Debug.Log ("rotacion: "+GameObject.Find ("CrossHair").transform.rotation);

	}
}
