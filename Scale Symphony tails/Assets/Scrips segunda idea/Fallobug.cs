using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallobug : MonoBehaviour
{
    GameObject pp;
    private void Start()
    {
        pp = GameObject.Find("Killzone");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        pp.GetComponent<Killzone>().Fallo();
       // Destroy(other.gameObject);
       
    }
}
