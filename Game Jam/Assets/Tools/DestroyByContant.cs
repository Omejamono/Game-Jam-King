using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContant : MonoBehaviour {
	public string tag;

	void OnTriggerEnter(Collider other){
		if (other.tag == tag) {
			Destroy (gameObject);
		}
	}
}
