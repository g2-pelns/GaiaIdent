using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHouseUp : MonoBehaviour {

    float speed;
    float current;
    public float end;

	// Use this for initialization
	void Start () {
        current = 0;
        end = 1500;
        speed = Random.Range(0.2f, 0.3f);
        transform.localScale = new Vector3(100f, 0f, 100f);

	}
	
	// Update is called once per frame
	void Update () {
        if (current < end)
        {
            //transform.Translate(Vector3.up * speed * Time.deltaTime);
            transform.localScale += new Vector3(0, speed);
            current += 5;
        }
        
	}
}
