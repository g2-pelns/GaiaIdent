using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Vector3 center;
    public Transform objCenter; 

    Vector3 vel = Vector3.zero;
    float flySpeed;

    public bool reverse;
    public bool stop;
    public bool up;


    void Start () {
        flySpeed = 0.5f;
        reverse = false;
        stop = false;
        up = false;
	}
	
	void Update () {
        //vel = vel + new Vector3(, , ); Y Z
        if (!stop)
        {
            if (!reverse)
            {
                vel.z = vel.z - 0.0005f * (center.z - transform.position.z);
                if (transform.position.z < -50)
                {
                    reverse = true;
                    up = true;
                }
            }
            if (reverse)
            {
                vel.z = vel.z + 0.00025f * (center.z - transform.position.z);
                if (transform.position.z > -40)
                {
                    stop = true;
                }
            }
        }

        if (stop)
        {
            if (transform.position.z > -10)
            {

            }
            else
            {
                vel.z = vel.z - 0.001f * (center.z - transform.position.z);
            }
        }

        if (up)
        {
            transform.position = transform.position + new Vector3(0f,flySpeed,0f);
        }

        transform.position = transform.position + vel;
        transform.LookAt(objCenter);
	}
}
