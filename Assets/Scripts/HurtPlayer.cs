using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

	public LevelManager TheLevelManager;
	// Use this for initialization
	void Start () {
		TheLevelManager = FindObjectOfType<LevelManager> ();
			}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
	
		if (other.tag == "Player") {
			TheLevelManager.Respawn ();
		}
	
	}
}
