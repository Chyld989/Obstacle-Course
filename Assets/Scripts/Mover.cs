using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	[SerializeField] float MoveSpeed = 10f;

	// Start is called before the first frame update
	void Start() {
		PrintInstructions();
	}

	// Update is called once per frame
	void Update() {
		MovePlayer();
	}

	void PrintInstructions() {
		Debug.Log($@"Welcome to the game");
		Debug.Log($@"Use WASD or your arrow keys to control the player block");
		Debug.Log($@"Don't hit the walls or obstacles!");
	}

	void MovePlayer() {
		float xSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
		float zSpeed = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;

		transform.Translate(xSpeed, 0f, zSpeed);
	}
}
