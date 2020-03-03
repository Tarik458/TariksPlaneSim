using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHandler : MonoBehaviour
{
    public GameObject Plane;
    public float Speed = 0;


    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) && Speed < 200)
        {
            Speed++;
        }
        if (Input.GetKey(KeyCode.LeftControl) && Speed > 0)
        {
            Speed--;
        }
        if(Input.GetKey(KeyCode.S))
        {
            Plane.transform.Rotate(-1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Plane.transform.Rotate(1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Plane.transform.Rotate(0f, 0.5f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Plane.transform.Rotate(0f, -0.5f, 0f);
        }
        if (Input.GetKey(KeyCode.Q) && Speed > 0)
        {
            Plane.transform.Rotate(0f, 0f, 0.3f);
        }
        if (Input.GetKey(KeyCode.E) && Speed > 0)
        {
            Plane.transform.Rotate(0f, 0f, -0.3f);
        }

        Plane.transform.Translate(Vector3.up * Time.deltaTime * Speed);
    }
}
