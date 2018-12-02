using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationSwitcher : MonoBehaviour {

	public Animator animator;
	public float timer;
	public string[] props = { "attack", "idle", "defence", "rest", "death" };

	public string currentProp = "idle";

	public bool isOpponent = false;

	private void Start () {

	}

	public void setProp (string prop) {
		timer = 0f;
		foreach (string s in props) {
			animator.SetFloat (s, .0f);
		}
		animator.SetFloat (prop, 1f);
		currentProp = prop;
	}

	private void Update () {
		if (currentProp == "idle") {
			foreach (string s in props) {
				animator.SetFloat (s, .0f);
			}
			timer = 0.2f;
		} else {
			timer += Time.deltaTime;
		}
		if (timer > 0.1) {
			foreach (string s in props) {
				animator.SetFloat (s, .0f);
			}
		}
		if (timer > 1.5f) {
			if (!isOpponent || Store.opponentHP > 0) {
				setProp ("idle");
			}
		}

	}

}