using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    Rigidbody2D notica;
    public float vel;


    void Awake()
    {
        notica = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
      
            notica.velocity = new Vector2(0, -vel);
      
        
    }

  //  Rigidbody2D notica;
  //  public float vel;
  //  bool Llamado = false;

  //  void Awake()
  //  {
  //      notica = GetComponent<Rigidbody2D>();
  //  }
  //  void Update()
  //  {
   //     if ((PlayerPrefs.GetInt("Start") == 1) && Llamado)

   //     {
   //         notica.velocity = new Vector2(0, -vel);
   //         Llamado = true;
  //      }

  //  }

    // Update is called once per frame

}
