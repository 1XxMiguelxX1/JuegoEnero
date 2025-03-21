using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class playercontroler : MonoBehaviour
{
    public float fuerzaVuelo = 3f;
    public float gravedad = 9f;
    private Rigidbody2D rb;
    private Animator Animator;

    public int maxHealth = 100;
    public int currentHealth;
    public Image healthBar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Animator = GetComponent<Animator>();
        //        rb.gravityScale = 0; // Desactiva la gravedad de Unity


    }

    void Update()
    {
        if (Input.GetMouseButton(0))  // Mientras esta presionado el clic izquierdo
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaVuelo);
            Animator.SetBool("subida", true);
            Animator.SetBool("bajada", false);
        }
        else
        {
            rb.velocity += new Vector2(0, -gravedad * Time.deltaTime);

            // Si la velocidad en Y es aproximadamente 0, cambiar a idle
            if (Mathf.Abs(rb.velocity.y) < 0.1f)
            {
                Animator.SetBool("subida", false);
                Animator.SetBool("bajada", false);
            }
            // Si la velocidad es negativa, activar la animaci�n de bajada
            else if (rb.velocity.y < 0)
            {
                Animator.SetBool("bajada", true);
                Animator.SetBool("subida", false);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("punto"))
        {
            Debug.Log("Obtuviste punto");
            GameManager.instance.SumarPunto();
        }
        else if (collision.CompareTag("obstaculo"))
        {
            TakeDamage(10); // Reducir la vida al colisionar con un obst�culo
            Destroy(collision.gameObject); // Destruir el objeto que golpe� al jugador
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Game Over");
            FindAnyObjectByType<GameOver>().MostrarGameOver(); // Mostrar pantalla de Game Over
        }
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        healthBar.fillAmount = (float)currentHealth / maxHealth;
    }
}
