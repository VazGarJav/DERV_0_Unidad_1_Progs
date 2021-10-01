using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBasico : MonoBehaviour
{
    long i = 0;
    public float desplazamiento;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        desplazamiento = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Prueba ");
        i++;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * desplazamiento * Time.deltaTime);
        }
    }
}
