using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardUI : MonoBehaviour
{

  public Image cardIcon;
  public TextMeshProUGUI cardName;
  public TextMeshProUGUI cardDescription;
  public CardData data;

  public int power;
  // Use this for initialization
  void Start()
  {
    changeData();
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void changeData()
  {

    if (data.name == "Attack")
    {
      power = Store.atk;
    }
    if (data.name == "BigAttack")
    {
      power = Store.atk + 1;
    }
    if (data.name == "Defense")
    {
      power = Store.def;
    }
    if (data.name == "GodAttack")
    {
      power = Store.atk * 2;
    }
    if (data.name == "Guard")
    {
      power = Store.def + 2;
    }
    if (data.name == "Heal")
    {
      power = Store.lvl + 1;
    }
    if (data.name == "Resurrect")
    {
      power = Store.lvl * 2 + 1;
    }


    cardName.text = data.cardName;
    cardDescription.text = data.cardDesc.Replace("{0}", power.ToString());
    cardIcon.sprite = data.cardSprite;
  }
}
