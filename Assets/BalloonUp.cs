using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonUp : MonoBehaviour {

	public Collision coll;
	public ConstantForce cForce;

	void Start () {
		cForce = GetComponent<ConstantForce> ();
	}

	// Use this for initialization
	void OnTriggerEnter (){
		cForce.force = new Vector3 (0, 1, 0);

	}
}
