using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenasController : MonoBehaviour
{
    public int sceneID = 1;
    private void OnCollisionEnter(Collision collision)
    {
        string etiqueta = collision.gameObject.tag;
        if (etiqueta.Equals("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
    
}
