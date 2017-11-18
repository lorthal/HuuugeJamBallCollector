using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

    public float MovementLength = 5.0f;
    float offset = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        offset += Time.deltaTime;
        //transform.position = 
	}
}
