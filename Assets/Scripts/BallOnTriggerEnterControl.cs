using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOnTriggerEnterControl : MonoBehaviour
{
    
    void Start()
    {
        
    }
        
    void Update()
    {
        
    }

    // Temas eden objeyi belirler
    void OnTriggerEnter(Collider go)
    {
        Debug.Log("Kutu içerisine giren obje:"+go.name);
    }
}
