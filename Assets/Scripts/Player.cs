using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	
	public GameObject bullet;
	public GameObject mas10;
	public GameObject mas50;
	public  float health = 10;
	string nameGameObjectShoot;
	RaycastHit hitInfo = new RaycastHit ();
	public static bool isShoot = false;
	public  static string enemyName = "";
	protected  Vector3 xyzDead = new Vector3 (0, 0, 0);
	protected Vector3 dir = new Vector3 (0, 0, 0);
	public static Vector3 bigCross = new Vector3 (0, 0, 0);
	Vector3 pjPosition;




	[HideInInspector]
	public Vector3 force;

	void Start ()
	{
		Cursor.visible = false;
		Enemy.EnemiesKilled = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		pjPosition = GameObject.Find ("3rd Person Controller").transform.localPosition;
		Vector3 headDir = new Vector3 (Camera.main.transform.forward.x/10,0,Camera.main.transform.forward.y/10);
		if(headDir.z <= 0){
			headDir.z = headDir.z * -1;
		}
	



		//GameObject.Find ("Box03").transform.RotateAround (pjPosition,new Vector3(0,0,1),0.1f);
		Debug.Log (headDir);
		transform.Translate (headDir);
		enemyName = "";
		if (health <= 0) {
			SceneManager.LoadScene ("Intentar");
		}
		
		//if(Input.GetMouseButtonDown(0))
		if (isShoot || Input.GetMouseButtonDown (0)) {
			AudioHandler.Instance.PlaySound (AudioHandler.Instance.Shoot);
			Instantiate (bullet, GameObject.Find ("StartProjectil").transform.position, GameObject.Find ("StartProjectil").transform.rotation);
			GameObject.Find ("Flamethrower").GetComponent<ParticleSystem> ().Play ();
			//Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
			bigCross = new Vector3 (GameObject.Find ("CrossHair").transform.position.x, GameObject.Find ("CrossHair").transform.position.y, GameObject.Find ("CrossHair").transform.position.z);
			//Ray ray = new Ray(Camera.main.transform.position,  GameObject.Find ("CrossHair").transform.position);
			Debug.DrawLine (GameObject.Find ("StartProjectil").transform.position, bigCross, Color.cyan);

			//Ray ray = new Ray(GameObject.Find ("Box03").transform.position, GameObject.Find ("CrossHair").transform.forward);
			//RaycastHit hit;
			//if(Physics.Raycast(ray, out hit)){
			//}

	
		
			/*if (Physics.Raycast (ray, out hitInfo)) {
			//	Debug.Log (hitInfo.collider.name + ", " + hitInfo.collider.tag);
				nameGameObjectShoot = hitInfo.collider.name;

				if (nameGameObjectShoot.Equals ("Zombie")) {
					xyzDead = (hitInfo.transform.gameObject.transform.position);

					Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
					GameObject clon = Instantiate (mas10, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
					//clon.transform.parent = GameObject.Find ("Main Camera").transform;
					//caidaZombieQuemado.CrossFade("caida zombie", 0f);
					Destroy (hitInfo.transform.gameObject);
					enemyName = "Zombie";		


				}
				if (nameGameObjectShoot.Equals ("Zombie2")) {
					
					Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
					GameObject clon = Instantiate (mas10, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
					//caidaZombieQuemado.CrossFade("Take 001 1", 2f);
					Destroy (hitInfo.transform.gameObject);
					print ("Zombie2");
					enemyName = "Zombie";		

				}
				if (nameGameObjectShoot.Equals ("Perro")) {
					
					Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
					GameObject clon = Instantiate (mas50, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
					Destroy (hitInfo.transform.gameObject);
					print ("PerroPerro");
					enemyName = "Perro";		
					
				}

			
			}*/

			Wait (1.0f);


		}
		if (!isShoot) {
			GameObject.Find ("Flamethrower").GetComponent<ParticleSystem> ().Stop ();
		}
		
	
		

	}

	void OnGUI ()
	{
		GUI.Box (new Rect (0, 0, 100, 30), "Health: " + Mathf.Max (0, health).ToString ());
		GUI.Box (new Rect (0, 30, 100, 30), "Kill Counter: " + Enemy.EnemiesKilled.ToString ());

	}


	IEnumerator Wait (float seconds)
	{
		yield return new WaitForSeconds (seconds);
	}





	
}
