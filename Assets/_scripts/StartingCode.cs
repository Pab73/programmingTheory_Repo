using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingCode : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitProject()
    {
        Application.Quit();
    }
    
}
