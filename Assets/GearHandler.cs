using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearHandler : MonoBehaviour
{
    public Animator animator;
    public bool gearUp = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            if (gearUp == false)
            {
                animator.SetBool("isAnimating", true);
                gearUp = true;
            }
            else if (gearUp == true)
            {
                animator.SetBool("isAnimating", false);
                gearUp = false;
            }
        }
    }
}
