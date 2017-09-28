using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(BoxCollider other)
    {
        Example3Player player = other.GetComponent<Example3Player>();
        if (player != null)
        {
          

        }

    }
}
