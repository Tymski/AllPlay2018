using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSceneOnKey : MonoBehaviour {

	public string SceneName;
	public string KeyName;

	public float coolDown = 0.1f;

	void Update () {
		if (Input.GetKeyDown (KeyName)) {
			SceneManager.LoadScene (SceneName);
		}
	}
}