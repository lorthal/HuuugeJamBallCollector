using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGrowthController : MonoBehaviour {

    public Vector3 AddScale = new Vector3(0.1f, 0.1f, 0.1f);
    public float AddMass = 0.1f;

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
            this.gameObject.transform.localScale += AddScale;
            this.gameObject.GetComponent<Rigidbody>().mass += AddMass;
            GameObject.Destroy(other.gameObject);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().IncreaseBalls();
        }
    }

}
