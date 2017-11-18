using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGrowthController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            this.gameObject.transform.localScale *= 1.5f;
            this.gameObject.GetComponent<Rigidbody>().mass *= 2.0f;
            GameObject.Destroy(other.gameObject);
            
        }
    }

}
