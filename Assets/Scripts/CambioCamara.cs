using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
   public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    void Start()
    {
       currentView = transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            currentView=views[0];
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            currentView=views[1];
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentView=views[2];
        }
    }
    private void LateUpdate() {
        transform.position = Vector3.Lerp(transform.position,currentView.position,Time.deltaTime*transitionSpeed);
    }
}
