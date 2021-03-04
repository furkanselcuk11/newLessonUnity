using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public GameObject go;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 pos = new Vector3(Random.Range(-20, 20), 8, Random.Range(-20, 20));
            //Instantiate(go, transform.position, transform.rotation);    // nesnenin bulunduğu pozisyona nesne oluşturulur
            Instantiate(go, pos, transform.rotation);   // random (pos) verilen değerlerde nesne oluşturulur
        }
    }
}
