using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerController : MonoBehaviour {

    bool isFinish = false;
    float timer = 0;
    public GameObject WinPanel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isFinish = true;

        }
    }

    private void Update()
    {
        if(isFinish)
        {
            timer += Time.deltaTime;
            if(timer >= 1.0f)
            {
                GetComponent<Animator>().enabled = false;
                this.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 5.0f * Time.deltaTime, gameObject.transform.position.z);
                //timer = 0;
            }

            if( gameObject.transform.position.y >= 5f)
                WinPanel.SetActive(true);
        }
    }
}
