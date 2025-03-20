using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab; // Prefab de la tortuga
    public float spawnInterval = 5f; // Tiempo entre apariciones
    public Transform[] spawnPoints; // Puntos donde aparece la tortuga
    public float speed = 2f;

    private void Start()
    {
        // Inicia la generación de ítems
        InvokeRepeating("SpawnItem", 2f, spawnInterval);
    }

    void SpawnItem()
    {
        if (spawnPoints.Length == 0) return; // Evita errores si no hay puntos de spawn

        // Selecciona un punto aleatorio
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        // Instancia la tortuga en el punto seleccionado
        Instantiate(itemPrefab, spawnPoint.position, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        // Dibuja los puntos de aparición en la escena
        Gizmos.color = Color.green;
        foreach (Transform spawnPoint in spawnPoints)
        {
            if (spawnPoint != null)
            {
                Gizmos.DrawSphere(spawnPoint.position, 0.5f);
            }
        }
    }


}
