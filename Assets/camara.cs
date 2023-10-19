using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject cubo; // creo una casilla visible para vincular un objeto 
    public float offestZ, offestY, offestX; //hago visibles las variables x y e z para poderlas modificar
    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.I)) //activamos la primera persona al hacer que las 3 variables sean 0
        {
            offestY = 0;
            offestX = 0;
            offestZ = 0;
        }
        if (Input.GetKeyDown(KeyCode.K))  //activamos la tercera persona
        {
            offestX = 0;
            offestZ = 2;
            offestY = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = cubo.transform.position; //codigo para primera persona
        transform.position = new Vector3 (cubo.transform.position.x, cubo.transform.position.y +offestY, cubo.transform.position.z -offestZ);
    }
}
