using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndUI : MonoBehaviour {
	
	public TextMeshProUGUI EndSceneText;
	public TextMeshProUGUI EndSceneDetailsText;

	// Use this for initialization
	void Start () {
		EndSceneText.text = "Przegrana!";
		string tmp = "Dotarto do poziomu " + Store.lvl.ToString() +" i pokoju " + Store.room.ToString() + ". Naciśnij dowolny przycisk aby kontynuować.";
		EndSceneDetailsText.text = tmp;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("MainMenu");
		} else if(Input.anyKey) {
			SceneManager.LoadScene("Level");
		}
	}
}
