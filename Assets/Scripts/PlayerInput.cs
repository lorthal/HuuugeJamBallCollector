using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector2 startScreenPos, endScreenPos;
    private Vector3 direction;

    public GameObject player;

    public float force, maxMagnitude;

    private float magnitude;

    public void OnDrag(PointerEventData eventData)
    {

        endScreenPos = eventData.position;

        magnitude = Vector3.Distance(endScreenPos, startScreenPos);

        direction = -(new Vector3(endScreenPos.x, 0, endScreenPos.y) - new Vector3(startScreenPos.x, 0, startScreenPos.y));

        if (magnitude >= maxMagnitude)
        {
            magnitude = maxMagnitude;
        }

        if (magnitude >= maxMagnitude / 2.0f)
        {
            direction += new Vector3(0, magnitude, 0);
        }

        direction = direction.normalized;

        Debug.DrawRay(player.transform.position, direction, Color.red);
        Debug.Log("Magnitude: " + magnitude);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startScreenPos = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;
        rb.AddForce(direction * magnitude * force);
    }
}
