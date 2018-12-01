using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationSwitcher : MonoBehaviour {

	public Animator animator;
	public string[] props = { "attack", "idle", "defence", "rest" };

	private void Start () {

	}

	public void setProp (string prop) {
		foreach (string s in props) {
			animator.SetFloat (s, .0f);
		}
		animator.SetFloat (prop, 1f);
	}

}