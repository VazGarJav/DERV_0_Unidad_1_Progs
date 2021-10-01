using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggersV1: MonoBehaviour
{
    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_vida;
    int puntaje;
    int vida;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        vida = 100;
        StartCoroutine("corrutinaVida");//sirve para crear un cronometro y es independiente de todo 
    }
    //una ventaja de usar colisiones es que se puede manejar con objeto pero si permaneces el objeto te aventara 
    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()//todo e tiempo esta decreciendo la vida 
    {
        //vida--;
       // txt_vida.text = vida.ToString();
    }


    private void OnCollisionEnter(Collision collision)
    {


        string etiqueta = collision.gameObject.tag;
        string nombre;
        Debug.Log("Colisión con: " + etiqueta);

        if (etiqueta.Equals("Enemigo")) // si la etiqueta tiene el nombre enemigo
        {
            nombre = collision.gameObject.name; //va a guardar ese nombre
            GameObject gameObj;                 //  lo va a buscar
            gameObj = GameObject.Find(nombre); // **   **

            Destroy(gameObj);//y lo destruye

            puntaje++;//para que aumente cada que se destruye un enemigo
            txt_puntaje.text = puntaje.ToString();
        }
        
    }

    

    //Corrutina
    IEnumerator corrutinaVida() 
    {
        while (true) 
        {
            vida-=5;
            txt_vida.text = vida.ToString();

            yield return new WaitForSeconds(1.0f);//yield es una forma de indicar que estamos retornando algo que ocupa el enumerator
            //y es solo para esta iteracion por lo que tiene que ir al final, sin salirce del enumador
        }
    }
    //Triggers, la diferencia entre ellos y colisiones es qu ela colision tal cual llegas e interactuas con el y requiere que el objeto
    //tenga solides, y por las fisicas te empuja o hay un empuje y un triggers es un lanzador, algo que esta lanzando algo y que cuando
    //se pasa por ahi se activa
    public void OnTriggerEnter(Collider other)//cuando estamos comenzando a interactuar con el objeto
    {

    }
    //mientras yo este en ese punto comenzemos a ganar vida
    public void OnTriggerStay(Collider other)//cuando se permanece esa interaccion 
    {
        string etiqueta = other.gameObject.tag;
        // string nombre;//cuando se tiene varios tipos de power up
        Debug.Log("Colisión con: " + etiqueta);

        if (etiqueta.Equals("PowerUp"))
        {
            vida++;
            txt_vida.text = vida.ToString();
        }
    }

    public void OnTriggerExit(Collider other)//cuando termina l interaccion
    {

    }


}

