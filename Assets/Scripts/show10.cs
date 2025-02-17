using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class show10 : MonoBehaviour {


	public Rigidbody rb;
	protected bool isForce = true;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();
	//	img.texture = texture;  
	//	img.enabled = true;


	}
	
	// Update is called once per frame
	void Update () {
	
		Destroy (this.gameObject,2);
	}

	void FixedUpdate() {

		if(isForce){rb.AddForce (0,8f,0 , ForceMode.Impulse); isForce = false;}

	

		//rb.MovePosition(new Vector3(xGap + (Sending.roll/100) ,  yGap + (Sending.pitch/100), zGap));


	}
}
