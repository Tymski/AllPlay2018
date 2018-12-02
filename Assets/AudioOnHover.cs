using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent (typeof (AudioSource))]
public class AudioOnHover : MonoBehaviour {

	public AudioClip audioSample;
	AudioSource audioSource;
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	// public void OnPointerEnter (PointerEventData pointerEventData) {
	// 	audioSource.PlayOneShot (audioSample);
	// }

}