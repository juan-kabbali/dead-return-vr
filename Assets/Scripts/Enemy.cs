using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	public float Range = 1000;
	public float Speed = 0.5f;
	GameObject PlayerLocal; 
	public static int EnemiesKilled;
	
	
	// Use this for initialization
	void Start () 
	{
		PlayerLocal = GameObject.Find("3rd Person Controller");

	}
	
	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.Distance(transform.position,PlayerLocal.transform.position);
		
		if (distance < Range) {
			FollowPlayer ();
			
			if (distance < 3) {
				AudioHandler.Instance.PlaySound (AudioHandler.Instance.Grito);
				PlayerLocal.GetComponent<Player> ().health--;
				Destroy (this.gameObject);
				Sending.sendVibration ();
			    


			
			}

			if (distance < 5 && gameObject.name.Equals ("Zombie2")) {
				AudioHandler.Instance.PlaySound (AudioHandler.Instance.Grito);
				PlayerLocal.GetComponent<Player> ().health--;
				Destroy (this.gameObject);
				Sending.sendVibration ();
				
				
				
				
			
			}

	
		}
	}
	
	void FollowPlayer()	{
		transform.LookAt(PlayerLocal.transform);
		transform.Translate(Vector3.forward * Time.deltaTime * Speed);

	}
	
	void OnDestroy()
	{
		if (ProjectileScript.enemyName.Equals ("Perro")) {

			EnemiesKilled = EnemiesKilled + 50;

		} 

		if(ProjectileScript.enemyName.Equals("Zombie")){
			EnemiesKilled = EnemiesKilled + 10;
		}

	


	}
}
