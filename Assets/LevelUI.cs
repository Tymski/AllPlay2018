using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelUI : MonoBehaviour {

	// Use this for initialization
	public TextMeshProUGUI levelSceneText;
	void Start () {
		changeData();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void changeData() {
		string tmp = "Level "+Store.lvl.ToString()+" - pokój "+Store.room.ToString();
		levelSceneText.text = tmp;
	}
}
