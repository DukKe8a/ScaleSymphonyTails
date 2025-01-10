using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private string nameScene;

    public void Change()
    {
        SceneManager.LoadScene(nameScene);
    }

    public void Exit() 
    {
        Debug.Log("LogOff");
        Application.Quit();
    }
}
