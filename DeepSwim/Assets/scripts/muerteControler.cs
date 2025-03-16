using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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