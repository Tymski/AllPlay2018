using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickARoom : MonoBehaviour {

	void Start () {
		foreach(Transform t in transform){
			t.gameObject.SetActive(false);
		}
		int rng = Random.Range(0,transform.childCount);
		transform.GetChild(rng).gameObject.SetActive(true);
	}
	

}
