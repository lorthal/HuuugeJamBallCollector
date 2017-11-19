using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject centerKiller, centerWinner;

    public int BallsToCollect = 4;
    int currentBalls = 0;

    private bool done;
    
	void Update () {
		if(!done && currentBalls >= BallsToCollect)
		{
		    done = true;
            centerKiller.SetActive(false);
            centerWinner.SetActive(true);
        }
	}

    public void IncreaseBalls()
    {
        currentBalls++;
    }
}
