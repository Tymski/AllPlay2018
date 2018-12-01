using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class SetPlayerNumbersUI : MonoBehaviour {

	public TextMeshProUGUI hp;
	public TextMeshProUGUI def;
	public TextMeshProUGUI atk;
	void Start () {
		hp.text = Store.hp.ToString ();
		def.text = Store.def.ToString ();
		atk.text = Store.atk.ToString ();
	}
}