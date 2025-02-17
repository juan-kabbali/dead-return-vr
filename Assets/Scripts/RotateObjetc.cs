using UnityEngine;
using System.Collections;

public class RotateObjetc : MonoBehaviour {

	// Use this for initialization
	public Vector3 axis;
	protected float angle = 10f;

	void Start () {
	
	//	rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		//angle = angle + 0.1f ;
		transform.RotateAround ( GameObject.Find ("First Person Controller").transform.position, axis, angle);




	}

	void FixedUpdate() {

	
		//rb.transform.RotateAround ( GameObject.Find ("First Person Controller").transform.position, axis, angle);


	}
}
