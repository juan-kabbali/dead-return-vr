using UnityEngine;
using System.Collections;

public class SpwnManagerBOSS : MonoBehaviour {

	GameObject[] spawnPoints;

	//BOSS VARIABLES
	public GameObject Boss;
	public static int EnemiesToKillForBoss = 150;
	public static bool didSpawnBoss;

	// Use this for initialization
	void Start () 
	{
		spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint"); // Find spawn points "object name"	
	}

	// Update is called once per frame
	void Update () 
	{

		if (didSpawnBoss) {
			return;
		}
				

		if (Enemy.EnemiesKilled >= EnemiesToKillForBoss) {
			//Instantiate (Boss, new Vector3 (255, 0, 285), Boss.transform.rotation);
		didSpawnBoss = true; }
		
		} 

}

		



