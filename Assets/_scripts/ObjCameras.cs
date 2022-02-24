using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCameras : VehiclesCamera
{   
   public void ClickedZoom()
    {        
        ZoomView();
    }
    public void ClickedBack()
    {
        ZoomOutView();        
    }    
}
