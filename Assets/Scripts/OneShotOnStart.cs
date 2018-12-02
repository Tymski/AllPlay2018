using System.Collections;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class OneShotOnStart : MonoBehaviour {
	public AudioClip audioSample;
	AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter () {
		audioSource.PlayOneShot (audioSample, 0.7F);
	}
}