using UnityEngine;

public class EnemigoAnguila : MonoBehaviour
{
    public Transform player; // Referencia a la nave del jugador
    public float speed = 2f; // Velocidad del enemigo
    public float attackRange = 0.8f; // Rango de ataque
    public int damage = 1; // Daño al jugador
    public float escenarioVelocidad = 2f; // Velocidad del desplazamiento del escenario
    public float distanciaDeseada = 3f; // Qué tan atrás queremos que esté el enemigo


    void Start()
    {
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

        if (player == null) return;

        // Punto objetivo detrás de la nave
        Vector2 targetPosition = (Vector2)player.position - (Vector2)player.up * distanciaDeseada;

        // Agregar variación para que no se alinee perfectamente
        targetPosition.x += Random.Range(-1f, 1f);

        // Distancia actual entre el enemigo y el punto deseado
        float distanceToTarget = Vector2.Distance(transform.position, targetPosition);

        // Reducir la velocidad del enemigo para simular el empuje del escenario
        float adjustedSpeed = speed - escenarioVelocidad * 0.5f; // Resta parte de la velocidad del escenario

        if (distanceToTarget < 1.5f)
        {
            adjustedSpeed *= 0.3f; // Si está muy cerca de la nave, reducir velocidad
        }

        if (distanceToTarget > 1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, adjustedSpeed * Time.deltaTime);
        }

        // Ajustar la dirección del enemigo
        FlipEnemy();

        // Si está en rango de ataque, atacar
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            Attack();
        }
    }

    // Método para ajustar la dirección del enemigo
    void FlipEnemy()
    {
        // Si el jugador está a la derecha, mirar a la derecha; si está a la izquierda, mirar a la izquierda
        if (player.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1); // Mirar a la derecha
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1); // Mirar a la izquierda
        }
    }

    void Attack()
    {
        Debug.Log("Enemigo Anguila ataca al jugador");
    }
}
