using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour {
	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			if (gameObject.tag == "Finish") {
				Debug.Log("You win!");
			} else {
				GetComponent<MeshRenderer>().material.color = Color.red;
				gameObject.tag = "Hit";
			}
		}
	}
}
