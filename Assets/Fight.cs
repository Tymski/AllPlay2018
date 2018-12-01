using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {

	public string CheckWin () {
		if (Store.hp <= 0) return "lose";
		if (Store.opponentHP <= 0) return "win";
		return "draw";
	}

	public int fightPhase = 0;

	public void ApplyCardEffects (CardUI cardPlayer, CardUI cardEnemy) {

		// PLAYER OFFENSIVE
		if (cardPlayer.data.cardType == "offensive") {
			if (cardEnemy.data.cardType == "defensive") {
				Store.opponentHP -= Mathf.Max (0, cardPlayer.power - cardEnemy.power);
			} else {
				Store.opponentHP -= cardPlayer.power;
			}
		}

		// ENEMY OFFENSIVE
		if (cardEnemy.data.cardType == "offensive") {
			if (cardPlayer.data.cardType == "defensive") {
				Store.opponentHP -= Mathf.Max (0, cardEnemy.power - cardPlayer.power);
			} else {
				Store.opponentHP -= cardEnemy.power;
			}
		}

		// HEALING
		if (cardPlayer.data.cardType == "passive") {
			Store.hp += cardPlayer.power;
		}
		if (cardEnemy.data.cardType == "passive") {
			Store.opponentHP += cardEnemy.power;
		}
	}

	IEnumerator FightSequence () {

		while (fightPhase == 0) {
			return null;
		}

		while (fightPhase == 1) {
			return null;
		}

		while (fightPhase == 2) {
			return null;
		}

		return null;
	}
}