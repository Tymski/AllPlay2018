using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationSwitcher : MonoBehaviour {

	public Animator animator;
	public float timer;
	public string[] props = { "attack", "idle", "defence", "rest" };

	private void Start () {

	}

	public void setProp (string prop) {
		timer = 0f;
		foreach (string s in props) {
			animator.SetFloat (s, .0f);
		}
		animator.SetFloat (prop, 1f);
	}

	private void Update () {
		// timer++;
		// if (timer > 1) setProp ("idle");
		// foreach (string s in props) {
		// 	animator.SetFloat (s, Mathf.Max (animator.GetFloat (s) - Time.deltaTime, 0));
		// }
	}

}