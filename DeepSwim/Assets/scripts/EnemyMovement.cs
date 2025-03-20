using UnityEngine;



public class EnemyMovement : MonoBehaviour

{

    public float speed = 2f; // Speed at which the enemy moves

    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer



    private void Start()

    {

        // Get the SpriteRenderer component

        spriteRenderer = GetComponent<SpriteRenderer>();

    }



    private void Update()

    {

        // Move the enemy to the left

        transform.Translate(Vector3.left * speed * Time.deltaTime);



        // Flip the sprite to face the moving direction

        if (spriteRenderer != null)

        {

            // Flip the sprite horizontally

            spriteRenderer.flipX = true; // Set to true if moving left, false if moving right

        }

    }

}