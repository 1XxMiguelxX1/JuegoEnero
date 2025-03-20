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

    public int maxHealth = 100;
    public int currentHealth;
    public Image healthBar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        UpdateHealthBar();
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
        else if (collision.CompareTag("obstaculo"))
        {
            TakeDamage(10); // Reducir la vida al colisionar con un obstáculo
            Destroy(collision.gameObject); // Destruir el objeto que golpeó al jugador
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
