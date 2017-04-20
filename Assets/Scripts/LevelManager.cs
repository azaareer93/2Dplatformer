using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public float TimeToRespawn;
	public PlayerController thePlayer;
	public GameObject DeathEvent;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Respawn(){
		StartCoroutine ("RespawnCo");
	}

	public IEnumerator RespawnCo(){
		
		thePlayer.gameObject.SetActive (false);
		Instantiate (DeathEvent, thePlayer.transform.position, thePlayer.transform.rotation);
		yield return new WaitForSeconds (TimeToRespawn);
		thePlayer.transform.position = thePlayer.respawnPosition;
		thePlayer.gameObject.SetActive (true);
	
	}

}
