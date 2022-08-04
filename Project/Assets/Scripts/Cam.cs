using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
    


	void Start () {
	}
	
	void LateUpdate () {

        var player = FindObjectOfType<Player>();
        transform.position = player.transform.position - new Vector3(0,0,10);

	}
}
