using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropController : MonoBehaviour {

    public float RotationSpeed = 1.0f;
    
	void Update () {
        this.gameObject.transform.Rotate(Vector3.right, Time.deltaTime * 50.0f * RotationSpeed);
	}
}
