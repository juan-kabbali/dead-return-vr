using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject enemy;
	GameObject[] spawnPoints;
	public float waveInterval;
	int enemiesToSpawn = 1;
	float nextWave;

	//BOSS VARIABLES

		
	// Use this for initialization
	void Start () 
	{
		spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint"); // Find spawn points "object name"	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(SpwnManagerBOSS.didSpawnBoss)
		{
			return;
		}

		/*if(Enemy.EnemiesKilled >= SpwnManagerBOSS.EnemiesToKillForBoss)
		{
			SpwnManagerBOSS.didSpawnBoss = true;
		}*/

		if(Time.time > nextWave)
		{
			SpawnWave();
			
			nextWave = Time.time + waveInterval;
		}
	}
	
	void SpawnWave()
	{
		for (int i = 0; i < enemiesToSpawn; i++) 
		{
			if(i > spawnPoints.Length - 1)
			{
				break;
			}
			
			GameObject clone = (GameObject)Instantiate(enemy, spawnPoints[i].transform.position, enemy.transform.rotation);
			clone.name = enemy.name;
		}
		
		enemiesToSpawn++;
	}
	
	void SpawnEnemy()
	{
		Vector3 SpawnPos = spawnPoints[Random.Range(0,spawnPoints.Length)].transform.position;
		GameObject clone = (GameObject)Instantiate(enemy, SpawnPos, enemy.transform.rotation);
		clone.name = enemy.name;
	}
}
