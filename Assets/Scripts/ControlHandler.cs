using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO.Ports;

public class ControlHandler : MonoBehaviour
{
    public char ControlValue;
    public SerialPort sp;
    public bool gearUp = false;
    public bool lightValue;

    void Start()
    {
        sp = new SerialPort("COM3", 9600);
        sp.ReadTimeout = 100;
        sp.Open(); // Need to add a Try ... Catch for this port opening
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.G))
        //{
        //    GearMover();
        //}
        //byte[] Cmd_Report = new byte[serialPort.BytesToRead];
        //serialPort.Read(Cmd_Report, 0, serialPort.BytesToRead);

        char[] tmpDirection = new char[sp.BytesToRead];
        //Debug.Log("BytesToRead: " + tmpDirection.Length);
        sp.Read(tmpDirection, 0, tmpDirection.Length);
        //Debug.Log("tmpDirection value: " + tmpDirection[tmpDirection.Length - 1]);
        ControlValue = tmpDirection[tmpDirection.Length - 1];
        //Debug.Log("Direction value: " + ControlValue.ToString());
        GearPos(ControlValue);
        LightCheck(ControlValue);
    }

    public bool GearState()
    {
        return gearUp;
    }

    public bool LightState()
    {
        return lightValue;
    }
    

    public void LightCheck(char lightOn)
    {
        if (lightOn == '1')
        {
            lightValue = false;
        }
        else if (lightOn == '3')
        {
            lightValue = true;
        }
    }

    public void GearPos(char direction)
    {
        //if (gearUp == false)
        //{
        //    animator.SetBool("isAnimating", true);
        //    gearUp = true;
        //}
        //else if (gearUp == true)
        //{
        //    animator.SetBool("isAnimating", false);
        //    gearUp = false;
        //}
        if (direction == '2')
        {
            gearUp = true;
        }
        else if (direction == '8')
        {
            gearUp = false;
        }
    }

}
