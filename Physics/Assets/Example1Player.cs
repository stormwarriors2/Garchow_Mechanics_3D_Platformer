using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1Player : MonoBehaviour {

    Rigidbody body;
    public float impulseJump;
    public float torqueScaler;

    void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float axisH = Input.GetAxis("Horizontal");
        //float axisV = Input.GetAxis("vertical");
        //terminal velocity is when air resistance slows thing down till it stop accelerating
        body.AddTorque(Vector3.forward * axisH * -1 * torqueScaler);


        if (Input.GetButtonDown("Jump"))
        {
            body.AddForce(transform.up * impulseJump, ForceMode.Impulse);
            //body.AddForce(transform.up * 5, ForceMode.Impulse);
            //body.AddForce(Vector3.up * 5, ForceMode.Impulse);
            // body.AddForce(new Vector3(0, 1, 0) * 10);
            //Force is applied every frame and multiplied by delta time
            //A impulse is when you want to apply a force on just one frame
        }





	}
}
