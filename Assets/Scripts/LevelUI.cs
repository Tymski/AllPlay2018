using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour {
	public TextMeshProUGUI levelSceneText;
	void Start () {
		string tmp = "Poziom " + Store.lvl.ToString () + " - Komnata " + Store.room.ToString ();
		levelSceneText.text = tmp;
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainMenu");
		} else if (Input.anyKey) {
			SceneManager.LoadScene ("Explore");
		}
	}
}