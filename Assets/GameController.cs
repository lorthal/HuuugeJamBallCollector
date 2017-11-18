using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int BallsToCollect = 2;
    int currentBalls = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentBalls >= BallsToCollect)
        {
            Debug.Log("Win");
        }
	}

    public void IncreaseBalls()
    {
        currentBalls++;
    }
}
