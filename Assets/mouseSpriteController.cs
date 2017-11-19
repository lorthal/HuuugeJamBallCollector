using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseSpriteController : MonoBehaviour {
    public float timer = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //timer -= Time.deltaTime;

        //if(timer <= 0)
        //{
        //    GameObject.Destroy(gameObject);
        //}
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
