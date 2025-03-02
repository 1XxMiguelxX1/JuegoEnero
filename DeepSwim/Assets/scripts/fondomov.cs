using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoScroll : MonoBehaviour
{
    public float velocidadScroll = 2f;  // qu� tan r�pido se mueve el fondo
    private Vector2 startPos;           // posici�n inicial para reiniciar

    public float anchoImagen = 1180f;     // aqu� defines el ancho de la imagen (o lo obtienes del sprite)

    void Start()
    {
        startPos = transform.position;  // guardamos la posici�n inicial
    }

    void Update()
    {
        // Mover el fondo hacia la izquierda
        transform.Translate(Vector2.left * velocidadScroll * Time.deltaTime);

        // Si el fondo se sali� completamente de la pantalla por la izquierda
        if (transform.position.x < startPos.x - anchoImagen)
        {
            // Lo reiniciamos al inicio (a la derecha)
            transform.position = new Vector2(startPos.x, transform.position.y);
        }
    }
}
