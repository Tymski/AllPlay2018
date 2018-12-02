using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardData", menuName = "AllPlay2018/CardData", order = 0)]
public class CardData : ScriptableObject {

	public string cardName;
	public string cardDesc;
	public string cardType;
	public Sprite cardSprite;
	
	public AudioClip voiceDescription;
	
	private void OnEnable() {
		
	}

}

