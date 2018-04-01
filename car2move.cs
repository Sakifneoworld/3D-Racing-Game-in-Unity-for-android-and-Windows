using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2move : MonoBehaviour {

    float speed = 3.0f;
    float turnspeed = 20.0f;


	void Start () {
		
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(speed , 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(-speed, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
        }



    }
}
