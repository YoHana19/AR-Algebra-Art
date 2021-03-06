﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

	private float currentSize = 0.0f;
	public float maxSize;
	private float currentPosition;
	private float mediatedPosition = -0.5f;
	private float finalPositon;

	// Use this for initialization
	void Start () {
		currentPosition = this.transform.position.x + mediatedPosition;
		finalPositon = maxSize / 2 + currentPosition;
		this.transform.localScale = new Vector3(currentSize, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentSize < maxSize) {
			currentSize += Time.deltaTime*2;
			this.transform.localScale = new Vector3(currentSize, 1, 1);
		}

		if (currentPosition < finalPositon) {
			currentPosition += Time.deltaTime;
			this.transform.position = new Vector3 (currentPosition, this.transform.position.y, this.transform.position.z);
		}
	}
}
