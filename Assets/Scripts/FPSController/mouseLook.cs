using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    [Range(50, 500)]
    public float sens;  // Mouse hassasiyeti
    public Transform body;  // Karakteri döndürmek

    float xRot = 0f;

    public Transform leaner;
    public float zRot;
    bool isRotating;

    public float smooting;
    float currentRot;
    private void Start()
    {
        Cursor.visible = false; // Mouse gizler
        Cursor.lockState = CursorLockMode.Locked;   // Mouse ekranın ortasına kitlenir
    }

    private void Update()
    {
        #region Camera Movement
        float rotX = Input.GetAxisRaw("Mouse X") * sens * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * sens * Time.deltaTime;

        xRot -= rotY;   //  Kamera sabit kalmaması için
        xRot = Mathf.Clamp(xRot, -80f, 80f);

        currentRot += rotX;
        currentRot = Mathf.Lerp(currentRot, 0, smooting * Time.deltaTime);

        transform.localRotation = Quaternion.Euler(xRot, 0f, currentRot); // Kamera sağa-sola dönüş
        body.Rotate(Vector3.up * rotX);
        #endregion

        #region Camera Lean
        if (Input.GetKey(KeyCode.E))
        {
            zRot = Mathf.Lerp(zRot,-20.0f, 5f*Time.deltaTime);
            // Lerp ile yumuşak geçiş yap ve -20'ye her saniye 5er 5er azalt
            isRotating = true;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            zRot = Mathf.Lerp(zRot,20.0f, 5f* Time.deltaTime);
            isRotating = true;
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
        {
            isRotating = false;
        } 

        if(!isRotating) // (isRotating == false)
        {
            zRot = Mathf.Lerp(zRot, 0.0f, 5f* Time.deltaTime);
        }

        leaner.localRotation = Quaternion.Euler(0, 0, zRot);
        #endregion
    }
}
