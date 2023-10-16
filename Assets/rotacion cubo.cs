using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cilindro; //saca el objeto a partir del cual rotara
    public Rigidbody rb; //nombramos el rigybody
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//sacar rigybody del objeto basico
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(cilindro.transform.position, Vector3.up, 90 * Time.deltaTime); //le pedimos al objeto con el script que gire al rededor del objeto a partir del cual rotara
        if (cilindro == null) // ==  es igual  =  es darle el valor y != es distinto a 
        {
            rb.useGravity = true; //activa la gravedad del rigybody
            Destroy(gameObject, 5);// se autodestruye en 10 segundos
        }
    }
}
