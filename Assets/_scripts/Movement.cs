using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : Vehicles // child class inheritance from base class Vehicles
{    
    // Update is called once per frame
    void Update()
    {        
        //abstract
        GetInputMoveMent();        

        if (isFlyable)
        {           
            ////overloading (Polymorphisme)
            Move(Pitch, Yaw, Roll, ForwardMov);            
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
