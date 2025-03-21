using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game2Over : MonoBehaviour
{
    public TMP_Text puntosText;
    public GameObject gameOverPanel2;

    public void MostrarGameOver()
    {
        gameOverPanel2.SetActive(true);
        puntosText.text = "Puntos: " + GameManager.instance.puntos;
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IRaMENU()
    {
        Debug.Log("Fuiste al menú, amiga ");
        SceneManager.LoadScene("Menu");
    }

}
