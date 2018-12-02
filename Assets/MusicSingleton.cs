using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSingleton : MonoBehaviour {

	public static MusicSingleton Instance;
	void Start () {
		if (Instance == null) {
			Instance = this;
		}
		if (Instance != this) {
			Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);
		}

	}

	// Update is called once per frame
	void Update () {

	}
}