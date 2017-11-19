using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerController : MonoBehaviour {

    public GameObject WinPanel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WinPanel.SetActive(true);
        }
    }
}
