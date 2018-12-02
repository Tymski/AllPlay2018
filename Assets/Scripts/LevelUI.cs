using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelUI : MonoBehaviour {
	// Use this for initialization
	public TextMeshProUGUI levelSceneText;
	void Start () {
		string tmp = "Level "+Store.lvl.ToString()+" - pokój "+Store.room.ToString()+". Naciśnij dowolny przycisk aby kontynuować.";
		levelSceneText.text = tmp;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("MainMenu");
		} else if(Input.anyKey) {
			SceneManager.LoadScene("Explore");
		}
	}
}
