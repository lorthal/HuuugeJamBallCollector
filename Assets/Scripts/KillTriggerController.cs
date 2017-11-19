using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTriggerController : MonoBehaviour
{
    public GameObject restart, inputPanel;

    public bool isOnEnter;

    void OnTriggerExit(Collider other)
    {
        if (!isOnEnter && other.CompareTag("Player"))
        {
            restart.SetActive(true);
            inputPanel.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (isOnEnter && other.CompareTag("Player"))
        {
            restart.SetActive(true);
            inputPanel.SetActive(false);
        }
    }
	
}
