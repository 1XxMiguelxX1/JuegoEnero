using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.VersionControl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
<<<<<<< HEAD
    public TMP_Text puntosText;
    public int puntos = 0;
    public AudioSource audioSource;
    public AudioClip pointSound;
=======
    public int metros = 0;
>>>>>>> parent of 0a5e443 (borre lo repeetido)


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

<<<<<<< HEAD
    /// /////////////////////


    //Reiniciar cuando muere

    //public void RestartScene()
    //{
    //    string currentSceneName = SceneManager.GetActiveScene().name;
    //    puntos = 0;
    //    SceneManager.LoadScene(currentSceneName);
    //}

 




    //Puntos
    public void SumarPunto()
    {
        puntos += 1; 
        PlayPointSound();
        ActualizarPuntosUI();
    }
    void ActualizarPuntosUI()
    {
        if (puntosText != null)

        {
            puntosText.text = puntos.ToString();
        }
    }

    private void Update()
    {
        puntosText = GameObject.Find("puntosText").GetComponent<TMP_Text>(); //"
    }

    ///Audio
    void Start()
    {
        if (audioSource == null)
        {
        audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlayPointSound()
    {
        audioSource.PlayOneShot(pointSound);
    }




  /*  private void OnTriggerEnter2D(Collider2D ether)
    {
        if(ether.CompareTag("obstaculo"))
        {
            Debug.Log("Game Over");
            FindAnyObjectByType<GameOver>().MostrarGameOver();
        }

    } */

=======

    void Start()
    {
        
    }


    public void RestartScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name; 
        metros = 0;
        SceneManager.LoadScene(currentSceneName);
    }
   
 private void Update()
    {
      //  metrosText = GameObject.Find("metrosText").GetComponent<TMP_Text>(); //"metrosText" es el nombre del canvas que aun no existe

    }
>>>>>>> parent of 0a5e443 (borre lo repeetido)
}
