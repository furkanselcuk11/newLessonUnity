﻿using System.Collections;
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
            Vector3 pos = new Vector3(Random.Range(-10, 10), 8, Random.Range(-10, 10));
            //Instantiate(go, transform.position, transform.rotation);    // nesnenin bulunduu pozisyonda nesne ekler
            Instantiate(go, pos, transform.rotation);
        }
    }
}
