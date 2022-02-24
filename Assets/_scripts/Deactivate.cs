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
        DisableAllControllersAndAudio();
        DisableAllGos();
    }

    private void Update()
    {
        foreach (var item in controllers)
        {
            if (item.isActiveAndEnabled)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DisableAllControllersAndAudio();
        }
    }

    public void EnablePlaneMovement()
    {
        controllers[0].enabled = true;
        planeAudio.Play();
        controllers[3].enabled = true;
    }

    public void EnableCarMovement()
    {
        controllers[1].enabled = true;
        carAudio.Play();
    }

    public void EnableBoatMovement()
    {
        controllers[2].enabled = true;
        boatAudio.Play();
        boatEngineAudio.Play();
    }

    public void DisableAllControllersAndAudio()
    {
        Cursor.lockState = CursorLockMode.None;
        foreach (var c in controllers) c.enabled = false;
        planeAudio.Stop();
        carAudio.Stop();
        boatAudio.Stop();
        boatEngineAudio.Stop();
    }

    public void DisableAllGos()
    {
        foreach (var item in GOs) item.SetActive(false);
    }

    public void EnableCanvas()
    {
        foreach (var item in GOs) item.SetActive(true);
    }
}
