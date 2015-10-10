using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour {

	void Start () {
//		var c = new Color(Random.value, Random.value, Random.value, 1f);
		var c = new Color(0, 1f, 0, 1f);
		GetComponent<Renderer>().material.color = c;
	}
}
