using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject centerKiller, centerWinner, platform;
    Vector3 targetPackmanLocation = new Vector3(0.1f, 1f, 0f);

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
        if(done)
        {
            if (centerWinner.transform.position.y <= targetPackmanLocation.y)
            {
                centerWinner.transform.position = new Vector3(centerWinner.transform.position.x, centerWinner.transform.position.y + Time.deltaTime, centerWinner.transform.position.z);
                platform.transform.position = new Vector3(platform.transform.position.x, platform.transform.position.y - Time.deltaTime, platform.transform.position.z);

            }

        }
	}

    public void IncreaseBalls()
    {
        currentBalls++;
    }
}
