using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOnTriggerEnterControl : MonoBehaviour
{
    int objectSkor = 0;
    public UnityEngine.UI.Text objectText;
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
        objectSkor += 1;
        objectText.text = "Giren Obje Sayısı:"+objectSkor+"";
        Debug.Log("Kutu içerisine giren obje:"+go.name);
    }
}
