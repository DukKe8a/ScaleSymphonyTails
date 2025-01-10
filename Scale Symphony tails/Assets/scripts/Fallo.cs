using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallo : MonoBehaviour
{
    public GameObject Dyzesharp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        Dyzesharp.GetComponent<Salud>().Vidaactual -= 1;
    }
}
