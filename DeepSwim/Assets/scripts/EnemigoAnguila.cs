using UnityEngine;

public class EnemigoAnguila : MonoBehaviour
{
    public Transform player; // Referencia a la nave del jugador
    public float speed = 2f; // Velocidad del enemigo
    public float attackRange = 0.5f; // Rango de ataque
    public int damage = 1; // Daño al jugador

    void Start()
    {
        // Buscar automáticamente al jugador si no está asignado en el Inspector
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
        }

        if (player == null)
        {
            Debug.LogError("No se encontró un objeto con el tag 'Player'. Asegúrate de asignar al jugador.");
        }
    }

    void Update()
    {
        if (player == null) return;

        // Simular que el enemigo se acerca a la nave aunque la nave no se mueva
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, player.position.y), speed * Time.deltaTime);

        // Si está en rango de ataque, atacar
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("Enemigo Anguila ataca al jugador");

        // Si el jugador tiene vida, hacerle daño
        //PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        //if (playerHealth != null)
        {
            //playerHealth.TakeDamage(damage);
        }
    }
}
