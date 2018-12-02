using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Nawigacja : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("MainMenu");
		} else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			Store.ADD_ONE_LEVEL();
			Store.RESET_ROOM();
			SceneManager.LoadScene("Level");
			// Debug.Log("lvl+");
		} else if(Input.GetKeyDown(KeyCode.RightArrow)) {
			Store.ADD_ONE_ROOM();
			// Debug.Log("room+");
			if((Store.room%2 == 0) || (Store.room == 0)) {
				SceneManager.LoadScene("Fight");
			} else {
				SceneManager.LoadScene("Level");
			}
		}
	}
}
