using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AddRawImageCrossHair : MonoBehaviour {


	public Texture2D texture;
	public RawImage img;
	protected float  TRESHYUP = 70f;
	protected float  TRESHYDOWN = -15f;
	protected float angle = 0f;

	void Start () {


		//rb = GetComponent<Rigidbody>();
		img.texture = texture;  
		img.enabled = true;
	
		//rb.MovePosition(new Vector3(xGap  /*+ (Sending.roll/100) */,  yGap/* + (Sending.pitch/10000)*/, zGap));
	

	}
		

	// Update is called once per frame
	void Update () {

		angle = Sending.pitch / 850;
		//angle = Sending.roll/ 8500;

		if(GameObject.Find ("CrossHair").transform.localPosition.y > TRESHYUP ){

			transform.Translate(0, -1f, 0);

		}

		if(GameObject.Find ("CrossHair").transform.localPosition.y < TRESHYDOWN){

			transform.Translate(0, 1f, 0);

		}


		transform.Translate(0, angle, 0);

		//img.gameObject.transform.Translate(new Vector3(0.0005f,0.0005f,0));
	/*	rotacionArribaAbajo = Sending.pitch/-100;
		if (rotacionArribaAbajo > 0.4 || rotacionArribaAbajo < - 0.4) {
			
			transform.RotateAround (GameObject.Find ("First Person Controller").transform.position, axisX, 0);

		} else {
			
			transform.RotateAround ( GameObject.Find ("First Person Controller").transform.position, axisX, rotacionArribaAbajo);
		}
	

		transform.RotateAround ( GameObject.Find ("First Person Controller").transform.position, axisY, Sending.roll/50);


		*/}

	/*void FixedUpdate() {

		rb.MovePosition(new Vector3( xGap + Sending.roll/100 ,  yGap + (Sending.pitch/100), zGap));
		 

	}*/




}
