using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {
    enum MovementDirection
    {
        Forward,
        Backward
    }

    MovementDirection movDir = MovementDirection.Forward;
    public float MovementSpeed = 0.1f;
    public float MovementLength = 0.1f;
    float offset = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        switch (movDir)
        {
            case MovementDirection.Forward:
                offset += MovementSpeed * Time.deltaTime;
                if (offset >= MovementLength)
                    movDir = MovementDirection.Backward;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);
                break;
            case MovementDirection.Backward:
                offset -= MovementSpeed * Time.deltaTime;
                if (offset <= 0)
                    movDir = MovementDirection.Forward;
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - offset);
                break;
            default:
                break;
        }
	}
}
