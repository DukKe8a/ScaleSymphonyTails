using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcliker : MonoBehaviour
{


    public bool Clickerfnf;
    public bool Altoque;
    public KeyCode teclas;
    public GameObject Dyzesharp;
    void Update()
    {
        if(Input.GetKeyDown(teclas) && Altoque)
        {

            StartCoroutine(ClickerfnfAtTheMoment());
               
        }
        if (Input.GetKeyDown(teclas) && Altoque)
        {

            

        }
    }
    IEnumerator ClickerfnfAtTheMoment()
    {
        Clickerfnf = true;
        yield return new WaitForSecondsRealtime(0.05f);
        Clickerfnf = false;

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Altoque = true;
        if(Clickerfnf)
        {
            Destroy(collision.gameObject);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Altoque = false;
    }


}
