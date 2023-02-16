using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour {
	[SerializeField] float timeToWait;

	MeshRenderer MeshRenderer;
	Rigidbody Rigidbody;

	// Start is called before the first frame update
	void Start() {
		MeshRenderer = GetComponent<MeshRenderer>();
		Rigidbody = GetComponent<Rigidbody>();

		MeshRenderer.enabled = false;
	}

	// Update is called once per frame
	void Update() {
		if (Time.time > timeToWait) {
			MeshRenderer.enabled = true;
			Rigidbody.useGravity = true;
		}
	}
}
