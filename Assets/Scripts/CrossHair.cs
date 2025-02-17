using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour {
	
	public Texture cross;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{




		GUI.DrawTexture(new Rect(Screen.width / 3.7f - cross.width / 2
			, Screen.height / 2 - cross.height,cross.width,cross.height),cross);

		GUI.DrawTexture(new Rect(Screen.width / (1.38f) - cross.width / 2
		                         , Screen.height / 2 - cross.height,cross.width,cross.height),cross);
	}
}
