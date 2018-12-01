using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetOpponentNumbersUI : MonoBehaviour {

	public TextMeshProUGUI hp;
	public TextMeshProUGUI def;
	public TextMeshProUGUI atk;
	void Update () {
		hp.text = Store.opponentHP.ToString ();
		def.text = Store.opponentDEF.ToString ();
		atk.text = Store.opponentATK.ToString ();
	}

}