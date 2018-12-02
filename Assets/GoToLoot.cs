using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLoot : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown ("enter") || Input.GetKeyDown ("return")) {
			SceneManager.LoadScene ("Loot");
		}
	}
}