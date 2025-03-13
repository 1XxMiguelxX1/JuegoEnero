using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{

    public TMP_Text puntosText;
    public GameObject gameOverPanel;
    
    public void MostrarGameOver ()
    {
        gameOverPanel.SetActive(true);
        puntosText.text = (("Puntos: ") + FindAnyObjectByType<GameManager>().puntos).ToString ();
    }
}
