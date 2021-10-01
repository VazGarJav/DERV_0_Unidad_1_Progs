using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ha entrado al trigger");
        string name = other.gameObject.name;
        Debug.Log(name);
        if(name=="Peluche")
        {
            Debug.Log("Hola");
            SceneManager.LoadScene(1);
        }
    }
}
