using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 transitionPos;

    public float softness = 5.0f;
    public float precision = 0.5f;

    GameObject player;
    void Start()
    {
        // Kodun bağlı olduğu objenin bir üst parentindeki objeyi seçer
        player = this.transform.parent.gameObject;
    }
    
    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(precision * softness, precision * softness));
        transitionPos.x = Mathf.Lerp(transitionPos.x, md.x, 1f / softness);
        transitionPos.y = Mathf.Lerp(transitionPos.y, md.y, 1f / softness);
        mousePos += transitionPos;

        transform.localRotation = Quaternion.AngleAxis(-mousePos.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mousePos.x, player.transform.up);
    }
}
