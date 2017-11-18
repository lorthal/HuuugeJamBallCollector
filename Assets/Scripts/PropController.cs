using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropController : MonoBehaviour {

    public float RotationSpeed = 1.0f;
    public Vector3 dir;
	void Update () {
        this.gameObject.transform.Rotate(dir, Time.deltaTime * 50.0f * RotationSpeed);
	}
}
