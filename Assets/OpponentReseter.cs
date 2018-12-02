using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentReseter : MonoBehaviour {

	void Start () {
		Store.opponentHP = Random.Range (Store.lvl, Store.lvl + 2);
		Store.opponentATK = Random.Range (Store.lvl, Store.lvl + 1);
		Store.opponentDEF = Random.Range (Store.lvl, Store.lvl + 2);
	}

}