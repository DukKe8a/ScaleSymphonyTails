using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLvl : MonoBehaviour
{
    [SerializeField] private string nameScene;
    [SerializeField] private string nameScene1;

    public void Change()
    {
        SceneManager.LoadScene(nameScene);
    }
    public void Change1()
    {
        SceneManager.LoadScene(nameScene1);
    }
}
