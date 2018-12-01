using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSetter : MonoBehaviour {

	public  List<CardData> listOfCards;
	void Awake () {
		Store.listOfCards=listOfCards;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
