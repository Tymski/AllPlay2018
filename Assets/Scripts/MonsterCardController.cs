using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCardController : MonoBehaviour {

	void Start () {
		int x = 0;
		foreach (Transform child in transform) {
			var card = child.gameObject.GetComponent<CardUI> ();
			if (x == 0 || x == 2) {
				// string[] tmptypes = { "defensive", "passive" };
				string[] tmptypes = { "offensive" };
				card.data = getRandomCard (tmptypes);
			}
			if (x == 1) {
				string[] tmptypes = { "defensive", "passive" };
				// string[] tmptypes = { "offensive" };
				card.data = getRandomCard (tmptypes);
			}
			card.changeData ();
			x++;
		}
	}

	public CardData getRandomCard (string[] type) {
		int len = Store.listOfCards.Count;
		while (true) {
			int i = Random.Range (0, len);
			int j = 0;
			for (; j < type.Length; j++) {
				if (Store.listOfCards[i].cardType == type[j]) {
					return Store.listOfCards[i];
				}
			}
		}
	}
}