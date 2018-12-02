using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour {

  public Image cardIcon;
  public TextMeshProUGUI cardName;
  public TextMeshProUGUI cardDescription;
  public CardData data;
  public int power;

  public bool isOpponent = false;
  // Use this for initialization
  void Start () {
    changeData ();
  }

  public void changeData () {

    if (data.name == "Attack") {
      power = Store.atk;
      if (isOpponent) power = Store.opponentATK;
    }
    if (data.name == "BigAttack") {
      power = Store.atk + 1;
      if (isOpponent) power = Store.opponentATK + 1;
    }
    if (data.name == "Defense") {
      power = Store.def;
      if (isOpponent) power = Store.opponentDEF;
    }
    if (data.name == "GodAttack") {
      power = Store.atk * 2;
      if (isOpponent) power = Store.opponentATK * 2;
    }
    if (data.name == "Guard") {
      power = Store.def + 2;
      if (isOpponent) power = Store.opponentDEF + 2;
    }
    if (data.name == "Heal") {
      power = Store.lvl + 1;
    }
    if (data.name == "Resurrect") {
      power = Store.lvl * 2 + 1;
    }

    cardName.text = data.cardName;
    cardDescription.text = data.cardDesc.Replace ("{0}", power.ToString ());
    cardIcon.sprite = data.cardSprite;
  }
}