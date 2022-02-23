using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Vehicles //inheritance
{
    [SerializeField] bool isFly;   

    // Update is called once per frame
    void Update()
    {
        //abstract
        GetInputMoveMent();
        if (isFly)
        {
            //for the plane we add a constant movement
            ForwardMov = 0.025f;
            //overloading 
            Move(Yaw, Pitch, Roll, Mathf.Clamp(ForwardMov, 0.0f, ForwardMov));
        }
        else
        {
            //overloading
            Move(Roll, ForwardMov);
        }

    }
    private void LateUpdate()
    {
        //abstraction
        SetBoundary();
    }
   
}
