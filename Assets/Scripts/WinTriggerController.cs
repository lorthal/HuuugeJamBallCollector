using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerController : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
    }
}
