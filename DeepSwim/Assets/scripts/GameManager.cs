using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.VersionControl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int metros = 0;


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
}
