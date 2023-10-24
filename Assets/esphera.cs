using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esphera : MonoBehaviour
{
    public float movimiento = 1f; // Velocidad de movimiento del cubo
    public Rigidbody fisicas; //llamada del rigidbody del cubo
    public float movx, movz;//saca los movimientos x y z 
    public bool salto;
    public bool suelo; 


    // Start is called before the first frame update
    void Start() //es el inicio del juego 
    {
        fisicas = GetComponent<Rigidbody>(); //obtenemos el rygybody
    }

    // Update is called once per frame
    void Update() //es el cuerpo del objeto es decir lo que sucede durante el juego
    {
        movx = Input.GetAxis("Horizontal"); //obtenems la tecla para el movimiento horizontal
        movz = Input.GetAxis("Vertical");//igual pero para la z

        if (Input.GetButtonDown("Jump"))
        {
            salto = true;
        }
    }
    private void FixedUpdate() //como el udape pero a tiempo real 
    {
        Vector3 NUEVELO = new Vector3(movx * movimiento, fisicas.velocity.y, movz * movimiento); //con este calculo procesamos el movimiento como vector constante nuevelo es el vector
        fisicas.AddForce(NUEVELO,ForceMode.Acceleration); // con force mode vamos añadiendo un tipo de fuerza en este caso de acceleracion para que el objeto vaya llendo mas rapido
        if (salto && suelo)
        {
            fisicas.AddForce(Vector3.up * 5, ForceMode.Impulse);
             //cuanto mas saltes mas impulso obtiene ya que usa un force mode de impulso el cual se acumula

        }
        if (salto)
        {
            fisicas.AddForce(Vector3.up * 5, ForceMode.Impulse);
            salto = false;
        }
       
    }
    void OnTriggerEnter(Collider other)
    {
        // Verificar si la colisión es con un objeto etiquetado como "moneda" y destruir ambos objetos
        if (other.gameObject.CompareTag("coin")) //si choca con las coins... 
        {
            Destroy(other.gameObject);//destrulles el objeto colisionado es decir las coin
        }

    }

    private void OnCollision(Collision collision) //cuando coliciona activa un efecto en este caso por ejemplo salto se vuelve falso 
    {if (collision.gameObject.CompareTag("suelo"))
        {
            suelo = true;
          
        }
        
    }

    private void OnCollisionExit(Collision collision) //lo mismo que el anterior pero al dejar de impactar con el objeto 
{
    if (collision.gameObject.CompareTag("suelo"))
    {
        suelo = false;
    }
}
}