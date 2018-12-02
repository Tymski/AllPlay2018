using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnChooseSound : MonoBehaviour {

	public AudioClip audioSample;
	AudioSource audioSource;
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	public void PlaySound () {
		audioSource.PlayOneShot (audioSample);
	}
}