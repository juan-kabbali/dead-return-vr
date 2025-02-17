using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

	public Slider healthBar;
	public float currentHealth;
	GameObject Player; 
	// Use this for initialization
	void Start () {
	
		Player = GameObject.Find("3rd Person Controller");
	}
	
	// Update is called once per frame
	void Update () {


		currentHealth = Player.GetComponent<Player> ().health;
		healthBar = GameObject.Find ("HealthBar").GetComponent<Slider> ();
		healthBar.value = currentHealth;
	
	}
}
