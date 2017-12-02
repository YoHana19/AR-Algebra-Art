using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManagerSize : MonoBehaviour {

	private InputManager inputManager;
	private InputField inputField;

	void Start() {
		inputManager = this.gameObject.transform.parent.gameObject.GetComponent<InputManager> ();
		inputField = GetComponent<InputField>();
		InitInputField();
	}

	public void InputLogger() {
		inputManager.size = float.Parse(inputField.text);
		Debug.Log(inputManager.size);
	}

	void InitInputField() {

		// 値をリセット
		inputField.text = "";
		// フォーカス
		inputField.ActivateInputField();
	}
}
