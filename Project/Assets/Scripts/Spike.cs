using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

	void Awake () {
        transform.position += new Vector3(Random.Range(10, 1000), -0);
	}
	
	void Update () {
		
	}
}
