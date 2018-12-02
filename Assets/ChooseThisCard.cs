using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseThisCard : MonoBehaviour {

	public PlayerCardChoose playerCardChoose;
	public bool thisCardWasChosen;

	public void ChooseMe () {
		if(thisCardWasChosen)return;
		playerCardChoose.chooseCard (GetComponent<CardUI> ().data);
		GetComponent<Button>().interactable = false;
		thisCardWasChosen = true;
	}
}