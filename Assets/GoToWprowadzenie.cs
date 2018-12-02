using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWprowadzenie : MonoBehaviour {

	void Update () {
		Debug.Log("GoToWprowadzenie");
		if (Input.GetKeyDown ("space")) {
			SceneManager.LoadScene ("Intro");
		}
	}
}