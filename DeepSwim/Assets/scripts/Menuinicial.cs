using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuinicial : MonoBehaviour
{
   public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Multijugador()
    {
        Debug.Log("Aqui pondria mi multijugador,,, si tuviera uno; ñañaras");
        Application.Quit();
    }
    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
