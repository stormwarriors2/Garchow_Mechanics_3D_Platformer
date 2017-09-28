using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2Player : MonoBehaviour {

    WheelJoint2D wheel;
    public float motorSpeed;

    // Use this for initialization
    void Start () {
        wheel = GetComponent<WheelJoint2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float axisH = Input.GetAxis("Horizontal");

        //float increase = axisH * 300;

        JointMotor2D motor = wheel.motor;
        //motor.motorSpeed = axisH *  -1 * motorSpeed;
        motor.motorSpeed = -axisH * motorSpeed;
        wheel.motor = motor;
	}

    public void TakeDamage()
    {
        print("I'm Taking damage");
    }
}
