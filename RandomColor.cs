using UnityEngine;
using System.Collections;

public class RandomColor : MonoBehaviour {

	void Start () {
//		var c = new Color(Random.value, Random.value, Random.value, 1f);
		var c = new Color(0, 0, 1f, 1f);
		GetComponent<Renderer>().material.color = c;
	}
}
