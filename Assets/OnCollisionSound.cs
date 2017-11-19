using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionSound : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
