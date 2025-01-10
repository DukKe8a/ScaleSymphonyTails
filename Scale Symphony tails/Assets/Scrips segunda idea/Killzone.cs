using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour
{
    int multiplicador = 1;
    int racha = 0;
    //private int antiracha = 0;

    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Medidor", 25);
        PlayerPrefs.SetInt("Streak", 0);
        PlayerPrefs.SetInt("Highpunt", 200);
        PlayerPrefs.SetInt("multi", 1);
        PlayerPrefs.SetInt("Noteshit", 4);
        PlayerPrefs.SetInt("Start", 1);

    }


    public void Rachita()
    {
        if (PlayerPrefs.GetInt("Medidor") < 50)
        {
            PlayerPrefs.SetInt("Medidor", PlayerPrefs.GetInt("Medidor") + 1);
        }
            racha =racha+1;
        //antiracha = antiracha + 5;
        if (racha >= 10)
        {
            multiplicador = 4;
        }
        else if (racha >= 6)
        {
            multiplicador = 3;
        }
        else if (racha >= 3)
        {
            multiplicador = 2;
        }
        else {
            multiplicador = 1;
        }

       
        if (racha>PlayerPrefs.GetInt("Highpunt"))
        {
            PlayerPrefs.SetInt("Highpunt", racha);
        }

        PlayerPrefs.SetInt("Noteshit", PlayerPrefs.GetInt("Noteshit")+1);

        Debug.Log("Rachita ejecutada. Racha actual: " + racha);
        Resetgui();

    }

    public void Fallo()
    {
        
        PlayerPrefs.SetInt("Medidor", PlayerPrefs.GetInt("Medidor") - 2);

        if (PlayerPrefs.GetInt("Medidor") < 0)
        {
            Perdiste();
        }

            racha = 0;
            multiplicador = 1;
            Resetgui();
        
       
    }

    public void Perdiste()
    {
        PlayerPrefs.SetInt("Start", 0);
        SceneManager.LoadScene(2);
        print("u suk");

    }
    public void Windos()
    {
        PlayerPrefs.SetInt("Start", 0);
        if (PlayerPrefs.GetInt("Highpunt") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Highpunt", PlayerPrefs.GetInt("Score"));
        }
            SceneManager.LoadScene(0);
        print("u suk a dik");

    }
    public void Resetgui()
    {
        PlayerPrefs.SetInt("racha", racha);
        PlayerPrefs.SetInt("multi", multiplicador);
       
    }
    public int Puntuacion()
    {
        return 100 * multiplicador;
    }
}
