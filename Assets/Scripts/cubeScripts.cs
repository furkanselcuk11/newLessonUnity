using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScripts : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
    // Script'in bağlı oldupu nesnenin Rigibody özelliğine erişir...
    rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   // Tuşa basıldığında yapılacak işlem
        if (Input.GetKey(KeyCode.Space))
        {
            // Kuvvet uygular
            rb.AddForce(new Vector3(0, 20.5f, 0));
        }
    }
}
