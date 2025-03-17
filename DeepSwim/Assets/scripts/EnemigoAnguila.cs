using UnityEngine;

public class EnemigoAnguila : MonoBehaviour
{
    public Transform player; // Referencia a la nave del jugador
    public float speed = 2f; // Velocidad del enemigo
    public float attackRange = 0.8f; // Rango de ataque
    public int damage = 1; // Da�o al jugador
    public float escenarioVelocidad = 2f; // Velocidad del desplazamiento del escenario
    public float distanciaDeseada = 3f; // Qu� tan atr�s queremos que est� el enemigo


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
            Debug.LogError("No se encontr� un objeto con el tag 'Player'. Aseg�rate de asignar al jugador.");
        }
    }

    void Update()
    {
        if (player == null) return;

        if (player == null) return;

        // Punto objetivo detr�s de la nave
        Vector2 targetPosition = (Vector2)player.position - (Vector2)player.up * distanciaDeseada;

        // Agregar variaci�n para que no se alinee perfectamente
        targetPosition.x += Random.Range(-1f, 1f);

        // Distancia actual entre el enemigo y el punto deseado
        float distanceToTarget = Vector2.Distance(transform.position, targetPosition);

        // Reducir la velocidad del enemigo para simular el empuje del escenario
        float adjustedSpeed = speed - escenarioVelocidad * 0.5f; // Resta parte de la velocidad del escenario

        if (distanceToTarget < 1.5f)
        {
            adjustedSpeed *= 0.3f; // Si est� muy cerca de la nave, reducir velocidad
        }

        if (distanceToTarget > 1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, adjustedSpeed * Time.deltaTime);
        }

        // Ajustar la direcci�n del enemigo
        FlipEnemy();

        // Si est� en rango de ataque, atacar
        if (Vector2.Distance(transform.position, player.position) <= attackRange)
        {
            Attack();
        }
    }

    // M�todo para ajustar la direcci�n del enemigo
    void FlipEnemy()
    {
        // Si el jugador est� a la derecha, mirar a la derecha; si est� a la izquierda, mirar a la izquierda
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
