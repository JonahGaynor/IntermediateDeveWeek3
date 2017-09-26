using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; 

public class EndScript : MonoBehaviour {

	public float changeInterval = 1f;
	private float currentTime;
	bool hasTriggered = false;

	void Start () {
		currentTime = changeInterval;
	}

	void OnTriggerEnter (Collider other)
	{
		hasTriggered = true;
	
	}

	void Update(){
		if (hasTriggered) {

			currentTime += Time.deltaTime;
			if (changeInterval <= currentTime) {
				Camera.main.backgroundColor = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f), 1f);
				currentTime = 0f;
			}

		}
	}
		
}