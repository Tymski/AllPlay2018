using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class AddNewLoot : MonoBehaviour {

	public TextMeshProUGUI lootText;

	void Start () {
		
		var rng = Random.Range (0, 3);
		if (rng == 0) {
			lootText.text = "Lepsza zbroja! (Defensywa +1)";
			Store.def += 1;
		}
		if (rng == 1) {
			lootText.text = "Dodatkowe potiony! (Zdrowie +1)";
			Store.hp += 1;
		}
		if (rng == 2) {
			lootText.text = "Świetny miecz! (Atak +1)";
			Store.atk += 1;
		}
	}

}