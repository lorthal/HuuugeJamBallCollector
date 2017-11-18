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
    private Rigidbody rb;
    public LineRenderer line;

    private bool pressed;

    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (pressed)
        {
            DrawTrajectory();
        }
    }

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
        //Debug.Log("Magnitude: " + magnitude);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startScreenPos = eventData.position;
        pressed = true;
        line.gameObject.SetActive(true);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;
        rb.AddForce(direction * magnitude * force);
        pressed = false;
        line.gameObject.SetActive(false);
    }

    void DrawTrajectory()
    {
        int vert = 20;
        line.positionCount = vert;

        Vector3 pos = player.transform.position;
        Vector3 vel = ((direction * magnitude * force) / rb.mass) * Time.fixedDeltaTime;
        Vector3 grav = Physics.gravity;

        for (int i = 0; i < vert; i++)
        {
            line.SetPosition(i, pos);
            vel += grav * Time.fixedDeltaTime;
            pos += vel * Time.fixedDeltaTime;
        }
    }
}
