using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrossHairMenu : MonoBehaviour {

	public Texture2D texture;
	public RawImage img;
	protected float  TRESHYUP = 120f;
	protected float  TRESHYDOWN = -120f;
	protected float angle = 0f;

	void Start () {
	
		img.texture = texture;  
		img.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {

		angle = Sending.pitch / 790 ;
		//angle = Sending.roll/ 8500;

		if(GameObject.Find ("CrossHair").transform.localPosition.y > TRESHYUP ){

			transform.Translate(0, -1f, 0);

		}

		if(GameObject.Find ("CrossHair").transform.localPosition.y < TRESHYDOWN){

			transform.Translate(0, 1f, 0);

		}


		transform.Translate(0, angle, 0);
	
	}
}
