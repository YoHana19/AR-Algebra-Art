using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onPlay() {
		GameObject[] cubeControllers = GameObject.FindGameObjectsWithTag("CubeController");
		foreach (GameObject cubeController in cubeControllers) {
			InputManager inputManager = cubeController.GetComponent<InputManager> ();
			inputManager.GenerateCube ();
		}
	}
}
