using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseThisCard : MonoBehaviour {

	public PlayerCardChoose playerCardChoose;

	public void ChooseMe () {
		playerCardChoose.chooseCard (GetComponent<CardUI> ().data);
	}
}