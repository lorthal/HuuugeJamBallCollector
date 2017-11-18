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
            this.gameObject.transform.localScale += new Vector3(0.1f,0.1f,0.1f);
            this.gameObject.GetComponent<Rigidbody>().mass += 0.1f;
            GameObject.Destroy(other.gameObject);
            
        }
    }

}
