using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{
    public GameObject explosion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Çarışan objeyi verir
    void OnCollisionEnter(Collision obj)
    {
        Debug.Log("OnCollisionEnter çarpılma gerçekleşti...");
        Destroy(obj.gameObject);    // Çarpılan nesneyi yok eder...
        Destroy(this.gameObject);   // Kodun bağlı olduğu nesneyi yok eder...
        // Patlama efekti ekler ve konumunu belirler...
        Instantiate(explosion, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
}
