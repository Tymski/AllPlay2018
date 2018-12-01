using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Navigate : MonoBehaviour {
	public void OnClickHandler() {
		SceneManager.LoadScene("MainMenu");
	}
}
