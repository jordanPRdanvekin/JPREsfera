using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemigos : MonoBehaviour
{
    public Transform objetivo; //se le pide que persiga a el elemento vinculado como objetivo en este caso el jugador
    public float speed = 2.0f; //para poderse mover nececita una velocidad ajustable.
    public float rotationSpeed = 20.0f;//esto le permitira rotar de manera aleatoria.
    private bool persigue = false; //al inicio no persigue al jugador por lo que es falso pero cuando se active activara la variable de persecusion
    private bool rota = true; //al inicio rota en el eje y 
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void FixedUpdate()
    {
        if ( rota)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0); //le pedimos que rote en el eje y
        }
        if (!persigue) //la ! significa no es decir que si no persigue es falso
        {
            rota = true;
        }
        if (persigue) //decimos que persigue es verdadero
        {
            rota = false;
            transform.LookAt(objetivo); //le decimos que mire a el objetivo 
            transform.Translate(Vector3.forward * speed * Time.deltaTime);//le decimos que se mueva en la direccion en la que mira
        }
    }

    // Update is called once per frame
    void Update()

    {
        RaycastHit hit; //invocar una sonda o area invisible de contacto 
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity)) //desde la parte frontal de la serpiente ( eje z) se proyecta un rayo podria proyectarse desde cualquier direccion pero hemos elejido z por que es la frontal
        //infinity es para decirle que lo proyecte asta el infinito si le doy valor el rayo sera mas corto 
        {
            if (hit.collider.gameObject.CompareTag("Player")) //activo un evento una ves el objeto colisione con la sonda invisible 
            {
                Debug.Log(hit.collider.gameObject.name);//mensaje de depuracion para saber que esta recibiendo una colicion
                persigue = true;
            }
            
        }


    

    }
}
