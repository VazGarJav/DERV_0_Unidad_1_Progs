using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Triggers_respown:MonoBehaviour
{
    public GameObject posInicio;

    [SerializeField]// es igual que public
    GameObject objetoLanzar;

    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }
    //una ventaja de usar colisiones es que se puede manejar con objeto pero si permaneces el objeto te aventara 
    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()//todo e tiempo esta decreciendo la vida 
    {
        
    }
    //para que caiga el cubo trigger
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger con: " + other.name);
        if (other.tag.Equals("Player"))
        {
            //clona un objeto en la posicion y en la rotacion que se le dijo, ademas el termino 'as' es como BDD, y lo regresa como un objeto
            GameObject obj = Instantiate(objetoLanzar, posInicio.transform.position,
                posInicio.transform.rotation) as GameObject;

            obj.name = "Enemigo_ " + i;
            Destroy(obj, 4); //el obj va a desaparecer en 4 segundos
        }
        
    }

}

