using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SimpleCylinderAndCube : MonoBehaviour
{
    public GameObject cilindro; // Referencia al cilindro alrededor del cual girará el cubo
    Rigidbody rb; // Referencia al componente Rigidbody del cubo
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtenemos el componente Rigidbody del cubo
        rb.useGravity = false; // Desactivamos la gravedad al inicio
    }

    // Update is called once per frame
    void Update()
    {
        // Hacemos que el cubo gire alrededor del cilindro
       
        if (cilindro == null)
        {
            // Si el cilindro se ha destruido, activamos la gravedad del cubo
            rb.useGravity = true;

            // Esperamos 10 segundos antes de autodestruir el cubo
            StartCoroutine(DestroyAfterDelay(10f));
        }
        else
        {
            transform.RotateAround(cilindro.transform.position, Vector3.up, 90 * Time.deltaTime);// si lo pongo al inicio puede causar problemas ya que al no existir el cilindro no puede acceder a este. 
        }

    }

    // Función para autodestruir el cubo después de un retraso
    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject); // Destruimos el cubo después del retraso especificado
    }
}
