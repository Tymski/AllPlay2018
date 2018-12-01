using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToExploreScene : MonoBehaviour {

	public void LoadScene(){
		SceneManager.LoadScene("Explore");
	}
}