using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medidor : MonoBehaviour
{
    float m, rotar;
    GameObject palo, palofake;
    void Start()
    {
        palo=transform.Find("palo").gameObject;
        palofake = transform.Find("palofake").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
        m= PlayerPrefs.GetInt("Medidor");
        palo.transform.localPosition = new Vector3((float)4.04+((m-25)/25),(float)1.5768, (float)0.02423789);

        palofake.transform.localRotation = Quaternion.Euler(0, 0,  ((25-m)*2));


    }
}
