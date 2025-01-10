using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Textoscore : MonoBehaviour
{
    public string nombre;

    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(nombre) + "";
    }
}
