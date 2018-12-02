using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardChoose : MonoBehaviour {

	public CardUI[] cards;
	public int iterator = 0;

	public void chooseCard (CardData cardData) {
		if (iterator >= 3) return;
		CardUI card = cards[iterator];
		card.data = cardData;
		card.changeData ();
		card.gameObject.SetActive (true);
		iterator++;
	}

}