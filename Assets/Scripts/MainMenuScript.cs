using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
		Debug.Log("probando");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		RaycastHit hitInfo;
		
		if(Physics.Raycast(transform.position,transform.forward * 100,out hitInfo))
		{
			if(Input.GetMouseButton(0))
			{
				Debug.Log (hitInfo.collider.name);
				switch(hitInfo.collider.name)
				{
				case "Jugar":
						SceneManager.LoadScene ("FPS SCENE");
						break;
				case "quit game text":
					Application.Quit();
					break;
				}
			}
		}
	}
}
