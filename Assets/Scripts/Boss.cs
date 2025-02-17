using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour {

	int vida = 100;
	Vector3 nuevaPosicion; 
	public float Range = 1000;
	public float Speed = 0.5f;
	GameObject PlayerLocal; 

	Random rm = new Random();
	public static bool leDieron = false;
	public static bool meCojieron = false;
	Rigidbody rb;
	public Animator caida;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();
		PlayerLocal = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () {


		if(SpwnManagerBOSS.didSpawnBoss) {

			float distance = Vector3.Distance(transform.position,PlayerLocal.transform.position);

		

			if (leDieron) {

				vida--;
				//calcularPosicionAleatoria ();
				leDieron = false;
			
			}
			if (meCojieron) {

				vida--;
				//calcularPosicionAleatoria ();
				meCojieron = false;
			}

			if (distance < Range) {
				FollowPlayer ();

				if (distance < 5 && gameObject.name.Equals ("BOSS")) {
					AudioHandler.Instance.PlaySound (AudioHandler.Instance.Grito);
					PlayerLocal.GetComponent<Player> ().health = 0;
					Sending.sendVibration ();
					Boss.meCojieron = true;






				}

			}


		}

		if(vida == 0){ 

			caida.CrossFade ("Take 001 1",0f);
			StartCoroutine(Example());
			Destroy (this.gameObject);
			SceneManager.LoadScene ("Final");
		}


		 else{

		return;

	}
	
	}

	void calcularPosicionAleatoria(){

		if(Random.Range(0,1)== 0){

			nuevaPosicion = new Vector3 (Random.Range(235,245), 0.5f, Random.Range(276,263) );
		}
		if(Random.Range(0,1)== 1){

			nuevaPosicion = new Vector3 (Random.Range(262,275), 0.5f, Random.Range(247,233) );
		}

		transform.LookAt(PlayerLocal.transform);
		transform.Translate(new Vector3(235f,0.5f,263f));
		Debug.Log ("me dieron nueva posicion: " + nuevaPosicion);

	
}

	void FollowPlayer()	{
		transform.LookAt(PlayerLocal.transform);
		transform.Translate(Vector3.forward * Time.deltaTime * Speed);

	}

	void OnDestroy()
	{
		if (ProjectileScript.enemyName.Equals ("Perro")) {

			Enemy.EnemiesKilled = Enemy.EnemiesKilled + 50;

		} 


	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(2);
		print(Time.time);
	}



}
