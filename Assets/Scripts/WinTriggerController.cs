using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerController : MonoBehaviour {

    bool isFinish = false;
    float timer = 0;
    public GameObject WinPanel;
    bool done = false;
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
            if(done == false && timer >= 1.0f)
            {
                GetComponent<Animator>().enabled = false;
                this.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 5.0f * Time.deltaTime, gameObject.transform.position.z);
                //timer = 0;
            }

            if( gameObject.transform.position.y >= 15f)
            {
                WinPanel.SetActive(true);
                done = true;
            }

        }
    }
}
