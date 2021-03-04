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
    // Objelerin belirli bir bölgeden geçmeleri veya belirli bir bölgeye girip girmediklerinin kontrolü 
    void OnTriggerEnter(Collider go)
    {
        Debug.Log("Kutu içerisine giren obje:"+go.name);
    }
}
