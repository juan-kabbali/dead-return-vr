using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class balamenu : MonoBehaviour {

	protected float speed = 100f; 
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();
		Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update () {

		FollowCross();
		Destroy (this.gameObject,0.3f);
	
	}

	void OnTriggerEnter(Collider otherObject)
	{
		if(otherObject.name == "jugar")
		{			
			SceneManager.LoadScene ("MAIN SCENE");
		}
		if(otherObject.name == "instrucciones")
		{
			SceneManager.LoadScene ("Instrucciones");

		}
		if(otherObject.name == "informacion")
		{
			SceneManager.LoadScene ("Informacion");
		
		}
		if(otherObject.name == "si")
		{

			SceneManager.LoadScene ("FPS SCENE");
		}

		if(otherObject.name == "no")
		{
			Application.Quit ();
			Debug.Log ("salir");

		}
		if(otherObject.name == "volver")
		{

			SceneManager.LoadScene ("Inicio");
		}
	}

	void FollowCross()
	{
		transform.LookAt( new Vector3(GameObject.Find ("CrossHair").transform.position.x, GameObject.Find ("CrossHair").transform.position.y, GameObject.Find ("CrossHair").transform.position.z ));
		//transform.LookAt(GameObject.Find ("CrossHair").transform);
		transform.Translate(Vector3.forward * Time.deltaTime * speed);

	}
}
