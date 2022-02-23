using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vehicles : MonoBehaviour
{
    [SerializeField]
    float maxX, minX, maxY, minY, maxZ, minZ;
    float _yaw;
    float _pitch;
    float _roll;
    float _forwardMov;
    //encapsulation
    public float Yaw { get => _yaw;  set => _yaw = value; }
    public float Pitch { get => _pitch; set => _pitch = value; }
    public float Roll { get => _roll; set => _roll = value; }
    public float ForwardMov { get => _forwardMov; set => _forwardMov = value; }

    //overloading
    protected  void Move(float roll, float forwardMov)
    {        
        transform.Translate(new Vector3(0.0f, 0.0f, forwardMov) * Time.deltaTime * .5f);
        transform.Rotate(0.0f, roll * Time.deltaTime * 25, 0.0f);
    }
    protected  void Move(float yaw ,float pitch, float roll , float forwardMov)
    {        
        transform.Translate(new Vector3(0.0f, 0.0f, forwardMov) * Time.deltaTime * 10f);
        transform.Rotate(pitch, yaw * Time.deltaTime * 150, -roll * Time.deltaTime * 35);
    }
    protected void SetBoundary()
    {
        transform.localPosition = new Vector3(Mathf.Clamp(transform.localPosition.x, minX, maxX), Mathf.Clamp(transform.localPosition.y, minY, maxY), Mathf.Clamp(transform.localPosition.z, minZ, maxZ));
    }
    protected void GetInputMoveMent()
    {
        _yaw = Input.GetAxis("Mouse X");
        _pitch = Input.GetAxis("Mouse Y") * -1;
        _roll = Input.GetAxis("Horizontal");
        _forwardMov = Input.GetAxis("Vertical");
    }
}
