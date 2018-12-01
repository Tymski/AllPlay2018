using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndUI : MonoBehaviour {
	
	public TextMeshProUGUI EndSceneText;
	public TextMeshProUGUI EndSceneDetailsText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		EndSceneText.text = "Przegrana!";
		string tmp = "Dotarto do poziomu " + Store.lvl.ToString() +" i pokoju " + Store.room.ToString();
		EndSceneDetailsText.text = tmp;
	}
}
