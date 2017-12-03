using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCube : MonoBehaviour {

	public GameObject cubeControllerUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddCubeContollerUI(){
		GameObject cubeControllerUIObj = Instantiate (cubeControllerUI);
		cubeControllerUIObj.transform.SetParent (this.transform, false);
	}
}
