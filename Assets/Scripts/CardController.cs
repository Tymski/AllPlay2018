using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour {

	// Use this for initialization
	int notOffensive = 0;
	int maxNotOffensive = 2;
	void Start () {
		foreach (Transform child in transform)
		{
			var card = child.gameObject.GetComponent<CardUI>();
			if(notOffensive < maxNotOffensive) {
				string[] tmptypes = {"defensive", "passive"};
				card.data = getRandomCard(tmptypes);
				notOffensive++;
			} else {
				string[] tmptypes = {"offensive"};
				card.data = getRandomCard(tmptypes);
			}
			card.changeData();
		}
	}
	
	public CardData getRandomCard(string []type) {
		int len = Store.listOfCards.Count;
		while(true) {
			int i = Random.Range(0, len);
			int j = 0;
			for(;j < type.Length; j++) {
				if(Store.listOfCards[i].cardType == type[j]) {
					return Store.listOfCards[i];
				}
			}
		}
	}
}
