using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class playercontroler : MonoBehaviour
{
    public float fuerzaVuelo = 3f;
    public float gravedad = 9f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))  // Mientras esté presionado el clic izquierdo
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaVuelo);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - gravedad * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("punto"))
        {
            Debug.Log("Obtuviste punto");
            GameManager.instance.SumarPunto();
        }
    //    else if (collision.CompareTag("obstaculo"))
    //    {
    //        Debug.Log("Game Over");
    //        FindAnyObjectByType<GameOver>().MostrarGameOver();
    //    }
    }




}
