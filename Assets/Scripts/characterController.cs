using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float characterSpeed = 10f;
    void Start()
    {
        
    }

        void Update()
    {
        // Karakterşn yönü ve hızını belirleme
        float zDirection = Input.GetAxis("Vertical") * characterSpeed;
        float xDirection = Input.GetAxis("Horizontal") * characterSpeed;
        zDirection *= Time.deltaTime;
        xDirection *= Time.deltaTime;
        transform.Translate(xDirection, 0, zDirection);
        
    }
}
