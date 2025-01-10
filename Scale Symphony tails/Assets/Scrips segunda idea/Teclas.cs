using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclas : MonoBehaviour
{
    SpriteRenderer colorin;
    public KeyCode tecla;
    bool active = false;
    GameObject note, sc;
    Color old;
    public bool Modo;
    public GameObject n;

    void Awake()
    {
        colorin = GetComponent<SpriteRenderer>();
    }
     void Start()
    {
        sc = GameObject.Find("Killzone");
        old = colorin.color;
    }

 
    void Update()
    {
        if (Modo)
        {

            if (Input.GetKeyDown(tecla))
            {

                Instantiate(n, transform.position, Quaternion.identity);
            }
        }
        else
        {

            if (Input.GetKeyDown(tecla))
            {

                StartCoroutine(Tocar());
            }

            if (Input.GetKeyDown(tecla) && active)
            {
                Destroy(note);
                sc.GetComponent<Killzone>().Rachita();

                Addscore();

                active = false;

            }
            else if (Input.GetKeyDown(tecla) && !active)
            {
                sc.GetComponent<Killzone>().Fallo();
            }
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "gg")
            sc.GetComponent<Killzone>().Windos();

        if (col.gameObject.tag == "note")
            note = col.gameObject;
            active = true;
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (active)
        {
            active = false;
           // sc.GetComponent<Killzone>().Fallo();
        }
    }

    void Addscore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + sc.GetComponent<Killzone>().Puntuacion());
    }

    IEnumerator Tocar()
    {
       
        colorin.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.1f);
        colorin.color = old;
    }
}
