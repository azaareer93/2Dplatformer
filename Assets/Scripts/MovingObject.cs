using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {
	public GameObject OjcectToMove;
	public Transform startPoint, endPoint;
	public float MoveSpeed;
	private Vector3 CurrentTarget;
	// Use this for initialization
	void Start () {
		CurrentTarget = endPoint.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		OjcectToMove.transform.position = Vector3.MoveTowards (OjcectToMove.transform.position, CurrentTarget, MoveSpeed * Time.deltaTime);

		if (OjcectToMove.transform.position == endPoint.position) {
			CurrentTarget = startPoint.position;

		}

		if (OjcectToMove.transform.position == startPoint.position) {
			CurrentTarget = endPoint.position;

		}

	}
}
