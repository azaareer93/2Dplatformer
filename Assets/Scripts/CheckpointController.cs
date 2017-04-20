using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour {

	public Sprite flageClosed;
	public Sprite flageOpened;
	private SpriteRenderer TheSpriteRender;
	public bool checkPointActive = false;
	// Use this for initialization
	void Start () {
		TheSpriteRender = GetComponent<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			TheSpriteRender.sprite = flageOpened;
			checkPointActive = true;
		}
}
}
