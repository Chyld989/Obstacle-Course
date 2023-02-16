using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {
	[SerializeField] float XRotationPerSecond;
	[SerializeField] float YRotationPerSecond;
	[SerializeField] float ZRotationPerSecond;

	// Update is called once per frame
	void Update() {
		gameObject.transform.Rotate(XRotationPerSecond * Time.deltaTime, YRotationPerSecond * Time.deltaTime, ZRotationPerSecond * Time.deltaTime);
	}
}
