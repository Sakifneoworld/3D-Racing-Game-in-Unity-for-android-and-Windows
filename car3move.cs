using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car3move : MonoBehaviour
{
    float speed = 50.0f  ;
    float turnspeed = 20.0f;
    float backspeed = 10.0f;
    float acceleration = 0.002f;
    float stop = .001f;
    float breakk = 0.004f ;
    
    float realtimeacceleration = 0f;


    public Text carspeed;


 


    void Start()
    {


    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (realtimeacceleration > 0)
                transform.Translate(new Vector3(realtimeacceleration, 0, 0) * speed * Time.deltaTime);
            if (realtimeacceleration < 1)
            {
                realtimeacceleration = realtimeacceleration + acceleration;
            }
            if (realtimeacceleration > -1 && realtimeacceleration <= 0)
                transform.Translate(new Vector3(realtimeacceleration, 0, 0) * backspeed * Time.deltaTime);
            if (realtimeacceleration > -1 && realtimeacceleration <= 0)
                realtimeacceleration = realtimeacceleration  + acceleration;

        }
        if (!(Input.GetKey(KeyCode.DownArrow)) && !(Input.GetKey(KeyCode.UpArrow)))
        {
            if (realtimeacceleration > 0)
                transform.Translate(new Vector3(realtimeacceleration, 0, 0) * speed * Time.deltaTime);
            if (realtimeacceleration > 0)
            {
                realtimeacceleration = realtimeacceleration - stop;
            }
            if (realtimeacceleration > -2 && realtimeacceleration <= 0)
                transform.Translate(new Vector3(realtimeacceleration, 0, 0) * backspeed * Time.deltaTime);
            if (realtimeacceleration > -2 && realtimeacceleration <= 0)
                realtimeacceleration = realtimeacceleration  + stop*2;

        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            if( realtimeacceleration > 0)
                transform.Translate(new Vector3(realtimeacceleration, 0, 0) * speed * Time.deltaTime);
            if (realtimeacceleration > 0)
                realtimeacceleration = realtimeacceleration - breakk;
            if (realtimeacceleration > -2 && realtimeacceleration <=0)
                transform.Translate(new Vector3(realtimeacceleration, 0, 0) * backspeed * Time.deltaTime);
            if (realtimeacceleration > -1 && realtimeacceleration <= 0)
                realtimeacceleration = realtimeacceleration - breakk;

        }





        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
        }



        carspeed.text = "Speed: "+string.Format("{0:N1}", realtimeacceleration*speed*2.5);



    }
}
