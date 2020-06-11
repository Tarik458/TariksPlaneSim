using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHelpDisplay : MonoBehaviour
{
    public Text tabTxt;
    public Text ControlsTxt;
    public bool showing = false;

    // Start is called before the first frame update
    void Start()
    {
        tabTxt = GameObject.Find("TabDisplay").GetComponent<Text>();
        ControlsTxt = GameObject.Find("ControlsDisplay").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && showing == false)
        {
            tabTxt.enabled = false;
            ControlsTxt.enabled = true;
            showing = true;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && showing == true)
        {
            tabTxt.enabled = true;
            ControlsTxt.enabled = false;
            showing = false;
        }

    }
}
