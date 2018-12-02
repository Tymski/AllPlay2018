using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fight : MonoBehaviour {

	public CardUI[] PlayerCards;
	public CardUI[] EnemyCards;

	public PlayerAnimationSwitcher playerAnimationSwitcher;
	public PlayerAnimationSwitcher monsterAnimationSwitcher;

	public string CheckWin () {
		if (Store.hp <= 0) return "lose";
		if (Store.opponentHP <= 0) return "win";
		return "draw";
	}

	public int fightPhase = 0;

	public void ApplyCardEffects (CardUI cardPlayer, CardUI cardEnemy) {

		Debug.Log (cardPlayer.data.cardType);
		Debug.Log (cardEnemy.data.cardType);

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
				Store.hp -= Mathf.Max (0, cardEnemy.power - cardPlayer.power);
			} else {
				Store.hp -= cardEnemy.power;
			}
		}

		// HEALING
		if (cardPlayer.data.cardType == "passive") {
			Store.hp += cardPlayer.power;
		}
		if (cardEnemy.data.cardType == "passive") {
			Store.opponentHP += cardEnemy.power;
		}

		var trans = cardPlayer.GetComponent<CanvasGroup> ();
		trans.alpha = 0.2f;
		var trans2 = cardEnemy.GetComponent<CanvasGroup> ();
		trans2.alpha = 0.2f;

		if (cardPlayer.data.cardType == "defensive") {
			playerAnimationSwitcher.setProp ("defence");
		}
		if (cardPlayer.data.cardType == "offensive") {
			playerAnimationSwitcher.setProp ("attack");
		}
		if (cardPlayer.data.cardType == "passive") {
			playerAnimationSwitcher.setProp ("rest");
		}
		if (cardEnemy.data.cardType == "defensive") {
			monsterAnimationSwitcher.setProp ("defence");
		}
		if (cardEnemy.data.cardType == "offensive") {
			monsterAnimationSwitcher.setProp ("attack");
		}
		if (cardEnemy.data.cardType == "passive") {
			monsterAnimationSwitcher.setProp ("rest");
		}
	}

	private void Start () {
		StartCoroutine ("FightSequence");
	}

	IEnumerator FightSequence () {

		Debug.Log ("Fight.cs");

		Debug.Log ("Fight.cs 1");
		while (fightPhase < 1) {
			yield return null;
		}
		ApplyCardEffects (PlayerCards[0], EnemyCards[0]);

		Debug.Log ("Fight.cs 2");
		while (fightPhase < 2) {
			yield return null;
		}
		ApplyCardEffects (PlayerCards[1], EnemyCards[1]);

		Debug.Log ("Fight.cs 3");
		while (fightPhase < 3) {
			yield return null;
		}
		ApplyCardEffects (PlayerCards[2], EnemyCards[2]);

		Debug.Log ("Fight.cs 4");
		yield return null;
	}
}