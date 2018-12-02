using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFightPhase : MonoBehaviour {

	public Fight fight;
	public void next () {
		fight.fightPhase++;
	}

	private void Update () {
		if (Input.GetKeyDown ("space")) {
			fight.fightPhase++;
		}
	}
}