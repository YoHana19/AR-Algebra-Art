using UnityEngine;
using System.Collections;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public float size;
	public float pos;
	public GameObject cube;

	void Start() {
		
	}

	public void GenerateCube(){
		Vector3 cubePos = new Vector3 (pos, 0, 0);
		GameObject cubeObj = Instantiate (cube, cubePos, this.transform.rotation);
		cubeObj.GetComponent<CubeManager> ().maxSize = size;
	}
		

}