using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointsRefresh : MonoBehaviour {

	public string texto = "";
	public Text puntos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		texto = Enemy.EnemiesKilled.ToString();
		puntos = GameObject.Find ("Points counter").GetComponent<Text> ();
		puntos.text = texto;
}
}
