using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector2 startScreenPos, endScreenPos;
    private Vector3 direction;

    public GameObject player;

    public float strength, maxMagnitude;

    private float magnitude;
    private Rigidbody rb;
    public LineRenderer line;

    private bool pressed;

    private Vector3 forceVector3;

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

        if (magnitude >= maxMagnitude)
        {
            endScreenPos = startScreenPos - (startScreenPos - endScreenPos).normalized * maxMagnitude;
            magnitude = maxMagnitude;
        }

        direction = -(new Vector3(endScreenPos.x, 0, endScreenPos.y) - new Vector3(startScreenPos.x, 0, startScreenPos.y));

        //if (magnitude >= maxMagnitude)
        //{
        //    magnitude = maxMagnitude;
        //}

        direction += new Vector3(0, magnitude, 0);

        direction = direction.normalized;

        forceVector3 = direction * magnitude * strength;

        Debug.DrawRay(player.transform.position, direction, Color.red);
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
        rb.AddForce(forceVector3);
        pressed = false;
        line.gameObject.SetActive(false);
    }

    void DrawTrajectory()
    {
        int vert = 100;
        line.positionCount = vert;

        Vector3 pos = player.transform.position;
        Vector3 vel = (forceVector3 / rb.mass) * Time.fixedDeltaTime;
        Vector3 grav = Physics.gravity;

        for (int i = 0; i < vert; i++)
        {
            line.SetPosition(i, pos);
            vel += grav * Time.fixedDeltaTime;
            pos += vel * Time.fixedDeltaTime;
        }
    }
}
