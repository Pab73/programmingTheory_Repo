using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehiclesUI : MonoBehaviour
{
    [SerializeField]
    private Text txt;    

    //Sets the name of the object this script is attached to
    protected void SetName()
    {  
        txt.text = gameObject.name;
    }


}
