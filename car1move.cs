using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car1move : MonoBehaviour {

    float speed = 3.0f;

    void Start () {

	}
	
	void Update () {
        transform.Translate(new Vector3(speed, 0, 0) * speed * Time.deltaTime);
    }
}
