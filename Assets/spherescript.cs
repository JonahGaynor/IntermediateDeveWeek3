﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherescript : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.useGravity = true;

		}
	}


}
