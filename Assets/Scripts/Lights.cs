using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public ControlHandler Handler;
    public Light planeLight;
    public bool lightValue;

    // Start is called before the first frame update
    void Start()
    {
        Handler = GameObject.Find("PlaneHandler").GetComponent<ControlHandler>();
        planeLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lightValue = Handler.LightState();

        if (lightValue == true)
        {
            planeLight.enabled = true;
        }
        else if (lightValue == false)
        {
            planeLight.enabled = false;
        }
    }
}
