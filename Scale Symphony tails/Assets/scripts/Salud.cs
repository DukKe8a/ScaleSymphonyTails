using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int Vidaactual;
    public int Maximavida;
    // Start is called before the first frame update
    void Start()
    {
        Vidaactual = Maximavida;

    }

 
    void Update()
    {
        if (Vidaactual > Maximavida)
        {
            Vidaactual = Maximavida;
        }
    }
}
