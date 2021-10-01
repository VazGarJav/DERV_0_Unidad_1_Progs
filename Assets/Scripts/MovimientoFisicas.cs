using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoFisicas : MonoBehaviour
{
    //long i = 0;
    public float desplazamiento;
    Rigidbody rb; 
    // Start is called before the first frame update
    //aqui es por frame la corrida es decir dependera de la computadora
    void Start()
    {
       // i = 0;
        desplazamiento = 10;
        rb = GetComponent<Rigidbody>(); //T tipo de dato parametrizado es decir cualuier tipo de dato
    }
    // aqui es por tiempo la corrida
    // Update is called once per frame
    void FixedUpdate()
    {
       // Debug.Log("Prueba ");
        //i++;

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Adelante");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Atras");
            rb.MovePosition(rb.position + transform.forward * -1*desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            rb.MovePosition(rb.position + transform.right * -1 * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime);
        }
    }
}
