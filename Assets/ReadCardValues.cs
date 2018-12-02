using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent (typeof (AudioSource))]
public class ReadCardValues : MonoBehaviour, IPointerEnterHandler {
	public AudioClip[] Numbers;
	public CardUI card;
	AudioSource audioSource;
	
	void Start() {
		card = GetComponent<CardUI> ();
		audioSource = GetComponent<AudioSource> ();
	} 
	
	public void OnPointerEnter (PointerEventData pointerEventData) {
		StartCoroutine("playSounds");
	}
	
		// StartCoroutine()
	IEnumerator playSounds() {
		audioSource.Play();
		while(audioSource.isPlaying) {
			yield return null;
		}
		
		audioSource.clip = card.data.voiceDescription;
		audioSource.Play();
		while(audioSource.isPlaying) {
			yield return null;
		}
		
		audioSource.clip = Numbers[card.power];
		audioSource.Play();
		while(audioSource.isPlaying) {
			yield return null;
		}
	}
}
