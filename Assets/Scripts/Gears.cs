using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gears : MonoBehaviour
{
    public Animator Gear;
    public bool GearUp = false;
    public ControlHandler Handler;

    // Start is called before the first frame update
    void Start()
    {
        Handler = GameObject.Find("PlaneHandler").GetComponent<ControlHandler>();
        Gear = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GearUp = Handler.GearState();

        if (GearUp == true)
        {
            Gear.SetBool("isAnimating", true);
        }
        else if (GearUp == false)
        {
            Gear.SetBool("isAnimating", false);
        }

        /*
        if (Input.GetKey(KeyCode.G) && GearUp == true)
        {
            Gear.SetBool("isAnimating", true);
        }
        else if (Input.GetKey(KeyCode.G) && GearUp == false)
        {
            Gear.SetBool("isAnimating", false);
        }
        */
    }

}