using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellor : MonoBehaviour
{
    float rotPower;
    // Update is called once per frame
    void Update()
    {
        rotPower += Time.deltaTime * 300;
        transform.Rotate(rotPower, 0.0f, 0.0f);
    }
}
