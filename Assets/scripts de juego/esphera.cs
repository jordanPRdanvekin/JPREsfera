using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    public float movimiento = 1f; // Velocidad de movimiento de la esfera
    public Rigidbody fisicas; // Llamada al componente Rigidbody de la esfera
    public float movx, movz; // Variables para el movimiento en los ejes x y z
    public bool salto;
    public bool suelo;

    // Start is called before the first frame update
    void Start() // Esto se ejecuta al inicio del juego
    {
        fisicas = GetComponent<Rigidbody>(); // Obtenemos el componente Rigidbody de la esfera
    }

    // Update is called once per frame
    void Update() // Esto se ejecuta durante el juego
    {
        movx = Input.GetAxis("Horizontal"); // Obtenemos la entrada para el movimiento horizontal
        movz = Input.GetAxis("Vertical"); // Lo mismo para el movimiento en el eje z

        if (Input.GetButtonDown("Jump"))
        {
            salto = true; // Se activa cuando se presiona el botón para saltar
        }
    }

    private void FixedUpdate() // Se ejecuta a intervalos regulares de tiempo
    {
        Vector3 NUEVELO = new Vector3(movx * movimiento, fisicas.velocity.y, movz * movimiento);
        // Calculamos el nuevo vector de movimiento con las entradas del jugador y la velocidad actual en el eje y
        fisicas.AddForce(NUEVELO, ForceMode.Acceleration);
        // Aplicamos una fuerza para mover la esfera

        if (salto && suelo)
        {
            fisicas.AddForce(Vector3.up * 5, ForceMode.Impulse);
            // Aplicamos un impulso hacia arriba para simular un salto
            salto = false; // Desactivamos el salto para evitar saltos múltiples
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Verificamos si hubo colisión con un objeto etiquetado como "moneda" y destruimos ambos objetos
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject); // Destruimos la moneda al recogerla
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            suelo = true; // Se activa cuando colisiona con el suelo
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("suelo"))
        {
            suelo = false; // Se desactiva al dejar de tocar el suelo
        }
    }
}
