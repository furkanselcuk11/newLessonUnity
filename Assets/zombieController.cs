using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour
{
    public Animator anim;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("run");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("idle");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("attack");
        }

    }
}
