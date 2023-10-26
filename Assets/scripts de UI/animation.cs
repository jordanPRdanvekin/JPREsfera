using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject boton; //CON ESTO SE ENCUENTRA EL OBJETO A USAR
    // Start is called before the first frame update
    void Start() //LAS ANIMACIONES DEBEN ESTAR EN STAR POR QUE SI NO EN UDAPE PEDIRAS ESA ANIMACION CONTINUAMENTE CREANDO UN BUCLE FATAL es decir se crasheara
    {

        //LeanTween.move(boton, boton.transform.position + new Vector3(39, 10, 0), 2.5f).setEaseInElastic().setRepeat(2);//movimientos de direccion con repeticion
        LeanTween.move(boton, boton.transform.position + new Vector3(39, 10, 0), 2.5f).setEaseInElastic().setLoopPingPong(2);//movimientos de direccion con repeticion en pingpong
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
