using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 

public class MenuObject : MonoBehaviour 
{
	public bool isQuit = false;
	public bool isInstructions = false;
	public bool isInformation = false;
	public bool isBack = false;
	public bool isPlay = false;
	
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
	
	void OnMouseDown()
	{
		if(isQuit)
		{
			Application.Quit();
		}
		if(isPlay)
		{
			SceneManager.LoadScene ("FPS SCENE");
		}
		if(isInstructions)
		{
			SceneManager.LoadScene ("Instructions");
		}
		if(isInformation)
		{
			SceneManager.LoadScene ("Information");
		}

		if(isBack)
		{
			SceneManager.LoadScene ("Main Menu");
		}
	}
}
