﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public float BounceStrength = 500.0f;
    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce((transform.rotation * Vector3.forward).normalized * BounceStrength);
        }
    }

}
