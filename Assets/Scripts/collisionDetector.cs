﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
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
        Destroy(obj.gameObject);    // Kodun bağlı olduğu nesneyi yok eder...
        Destroy(this.gameObject);   // Çarpılan nesneyi yok eder...
    }
}
