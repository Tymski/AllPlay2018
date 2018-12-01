using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextLevelInfoDisplay : MonoBehaviour {

	TextMeshProUGUI text;
	void Start () {
		text = gameObject.GetComponent<TextMeshProUGUI> ();
		text.text = "Hello";
	}

	private void Awake() {
		
	}

	private void Update() {
		
	}

	


}