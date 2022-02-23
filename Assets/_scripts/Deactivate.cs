using UnityEngine;

public class Deactivate : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] controllers;
    [SerializeField] GameObject[] GOs;
    [SerializeField] AudioSource planeAudio;
    [SerializeField] AudioSource carAudio;
    [SerializeField] AudioSource boatAudio;    
    [SerializeField] AudioSource boatEngineAudio;    

    void Start()
    {
        foreach (var c in controllers) c.enabled = false;
        foreach (var item in GOs) item.SetActive(false);
    }
    public void DisableAllControllersAndAudio()
    {
        foreach (var c in controllers) c.enabled = false;
        foreach (var item in GOs) item.SetActive(false);
        planeAudio.Stop();
        carAudio.Stop();
        boatAudio.Stop();
        boatEngineAudio.Stop();
    }
    public void EnableCanvas()
    {
        foreach (var item in GOs) item.SetActive(true);
    }

    public void EnablePlaneMovement()
    {
        if (!controllers[0].isActiveAndEnabled)
        {
            controllers[0].enabled = true;
            planeAudio.Play();
            controllers[3].enabled = true;
        }
        else
        {
            controllers[0].enabled = false;
            planeAudio.Stop();
            controllers[3].enabled = false;
        }       
    }
    public void EnableCarMovement()
    {
        if (!controllers[1].isActiveAndEnabled)
        {
            controllers[1].enabled = true;
            carAudio.Play();
        }
        else
        {
            controllers[1].enabled = false;
            carAudio.Stop();
        }
    }
    public void EnableBoatMovement()
    {
        if (!controllers[2].isActiveAndEnabled)
        {
            controllers[2].enabled = true;
            boatAudio.Play();
            boatEngineAudio.Play();
        }
        else
        {
            controllers[2].enabled = false;
            boatAudio.Stop();
            boatEngineAudio.Stop();
        }
    }
}
