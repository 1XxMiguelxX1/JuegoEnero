using UnityEngine;

public class EnemigoAnguila : MonoBehaviour
{
    public Transform player; // Referencia a la nave del jugador
    public float speed = 2f; // Velocidad del enemigo
    public float attackRange = 0.5f; // Rango de ataque
    public int damage = 1; // Da�o al jugador

    void Start()
    {
        // Buscar autom�ticamente al jugador si no est� asignado en el Inspector
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
            Debug.LogError("No se encontr� un objeto con el tag 'Player'. Aseg�rate de asignar al jugador.");
        }
    }

    void Update()
    {
        if (player == null) return;

        // Simular que el enemigo se acerca a la nave aunque la nave no se mueva
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, player.position.y), speed * Time.deltaTime);

        // Si est� en rango de ataque, atacar
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("Enemigo Anguila ataca al jugador");

        // Si el jugador tiene vida, hacerle da�o
        //PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        //if (playerHealth != null)
        {
            //playerHealth.TakeDamage(damage);
        }
    }
}
