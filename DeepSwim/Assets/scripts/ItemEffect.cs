using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    public int healAmount = 20; // Cantidad de vida que recupera
    public float speed = 2f; // Speed at which the enemy moves
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer

    private void Start()

    {

        // Get the SpriteRenderer component

        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            collision.GetComponent<playercontroler>().TakeDamage(-healAmount); // Recuperar vida
            Destroy(gameObject); // Elimina la tortuga después de recogerla
        }
    }
    private void Update()

    {

        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (spriteRenderer != null)

        {

            // Flip the sprite horizontally

            spriteRenderer.flipX = true; // Set to true if moving left, false if moving right

        }
    }
}
