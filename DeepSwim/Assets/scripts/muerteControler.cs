using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
//public class muerteControler : MonoBehaviour
//{
//    private void OnCollisionEnter2D(Collision2D collision)

//    {
//        if (collision.gameObject.CompareTag("Player"))
//        {
//            Destroy(collision.gameObject);
//            // GameManager.instance.RestartScene();
//            // Debug.Log("Game Over");
//            // FindAnyObjectByType<GameOver>().MostrarGameOver();


//        }
//    }
//}


public class muerteControler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Game Over");
            FindAnyObjectByType<GameOver>().MostrarGameOver();
        }
    }
}
=======
public class muerteControler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            Destroy(collision.gameObject);
            GameManager.instance.RestartScene();
        }
    }
}
>>>>>>> parent of 0a5e443 (borre lo repeetido)
