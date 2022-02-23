using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehiclesCamera : MonoBehaviour
{
    [SerializeField] GameObject objCamera;
    [SerializeField] GameObject objCameraCanvas;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject obj;
    [SerializeField]Deactivate deactivate;

    protected void ZoomView()
    {
        deactivate.EnableCanvas();
        mainCam.GetComponent<AudioListener>().enabled = false;
        mainCam.SetActive(false);
        objCameraCanvas.SetActive(false);
        objCamera.SetActive(true);
        objCamera.GetComponent<AudioListener>().enabled = true;
        obj.GetComponentInChildren<Canvas>().sortingOrder = 10;
    }
    protected void ZoomOutView()
    {
        obj.GetComponentInChildren<Canvas>().sortingOrder = 0;
        deactivate.DisableAllControllersAndAudio();
        objCamera.GetComponent<AudioListener>().enabled = false;
        objCamera.SetActive(false);
        mainCam.SetActive(true);
        mainCam.GetComponent<AudioListener>().enabled = true;
        objCameraCanvas.SetActive(true);
        
    }
}
