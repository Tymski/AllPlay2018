using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("MainMenu");
		} else if(Input.anyKey) {
			SceneManager.LoadScene("Explore");
		}
	}
}
