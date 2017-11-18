using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnesController : MonoBehaviour {

    public float magnesStrength = 5f;
    public int magnesDirection = 1;
    bool isBallInRadius = false;
    GameObject ball;
    private void FixedUpdate()
    {
        if(isBallInRadius)
        {
            Vector3 directionFromMagnet = transform.position - ball.transform.position;
            float distanceFromBall = Vector3.Distance(transform.position, ball.transform.position);
            float magnesDistanceStrength = (10.0f / distanceFromBall) * magnesStrength;

            if(ball != null)
                ball.GetComponent<Rigidbody>().AddForce(magnesDistanceStrength*(directionFromMagnet * magnesDirection) * Time.deltaTime, ForceMode.Force);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isBallInRadius = true;
            ball = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isBallInRadius = false;
            ball = null;
            
        }
    }
}
