using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	
	protected float speed = 100f; 
	Vector3 bigCross = new Vector3 (0,0,0);
	public Rigidbody rb;
	public GameObject mas10;
	public GameObject mas50;
	protected  Vector3 xyzDead = new Vector3(0,0,0);
	protected Vector3 dir = new Vector3(0,0,0);
	public  static string enemyName = "";

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		Cursor.visible = false;
		//dir = Camera.main.transform.forward;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//bigCross = new Vector3(GameObject.Find ("CrossHair").transform.position.x, GameObject.Find ("CrossHair").transform.position.y,GameObject.Find ("CrossHair").transform.position.z);
		//transform.Translate(dir * speed * Time.deltaTime, Space.World);
		//transform.Translate(dir, Space.World);
		FollowCross();
		Destroy (this.gameObject,0.3f);
		//transform.Translate (bigCross.x * speed * Time.deltaTime , bigCross.y * speed * Time.deltaTime, bigCross.z * speed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider otherObject)
	{
		if(otherObject.name == "Zombie")
		{			
			Debug.Log ("le di al verde");
			xyzDead = (otherObject.transform.position);
			dir = GameObject.Find ("3er Person Controller").transform.position;
			Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
			GameObject clon = Instantiate (mas10, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
			enemyName = "Zombie";		
			Destroy(otherObject.gameObject);
		}
		if(otherObject.name == "Zombie2")
		{
			Debug.Log ("le di al quemado");
			xyzDead = (otherObject.transform.position);
			dir = GameObject.Find ("3rd Person Controller").transform.position;
			Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
			GameObject clon = Instantiate (mas10, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
			enemyName = "Zombie";		
			Destroy(otherObject.gameObject);

		}
		if(otherObject.name == "Perro")
		{
			
			xyzDead = (otherObject.transform.position);
			dir = GameObject.Find ("3rd Person Controller").transform.position;
			Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
			GameObject clon = Instantiate (mas50, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
			enemyName = "Perro";		
			Destroy(otherObject.gameObject);

		}
		if(otherObject.name == "BOSS")
		{
			Debug.Log ("le di al boss");
			xyzDead = (otherObject.transform.position);
			dir = GameObject.Find ("3rd Person Controller").transform.position;
			Vector3 dirGap = new Vector3 (dir.x , dir.y , dir.z);
			GameObject clon = Instantiate (mas50, dirGap, GameObject.Find ("Main Camera").transform.rotation) as GameObject;
			enemyName = "Perro";		
			Boss.leDieron = true;

		}
	}

	void FollowCross()
	{
		transform.LookAt( new Vector3(GameObject.Find ("CrossHair").transform.position.x, GameObject.Find ("CrossHair").transform.position.y, GameObject.Find ("CrossHair").transform.position.z ));
		//transform.LookAt(GameObject.Find ("CrossHair").transform);
		transform.Translate(Vector3.forward * Time.deltaTime * speed);

	}


				
	
}
