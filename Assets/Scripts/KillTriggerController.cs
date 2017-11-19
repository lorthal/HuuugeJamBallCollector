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
            EndGame(other);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (isOnEnter && other.CompareTag("Player"))
        {
            EndGame(other);
        }
    }


    void EndGame(Collider other)
    {
        restart.SetActive(true);
        inputPanel.SetActive(false);
        GetComponent<AudioSource>().Play();
        other.GetComponent<MeshRenderer>().enabled = false;
        other.enabled = false;
        other.gameObject.transform.Find("PS_explosion").gameObject.SetActive(true);
    }

}
