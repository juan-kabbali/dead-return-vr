using UnityEngine;
using System.Collections;

public class Spinny : MonoBehaviour {

	public static bool isSpinny;
	 

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		rotar ();

	}


	public void rotar(){


		if(isSpinny){
		transform.Rotate(0,90*Time.deltaTime,0);
			//print("rotando");
		}
		else{
		transform.Rotate(0,0*Time.deltaTime,0);
			//print("quieto");
	    }
	}








}





	
	
