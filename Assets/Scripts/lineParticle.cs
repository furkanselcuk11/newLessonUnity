using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineParticle : MonoBehaviour
{
    LineRenderer line;

    Transform Cube_1;
    Transform Cube_2;
    Transform Cube_3;
    void Start()
    {
        line = GetComponent<LineRenderer>();

        Cube_1 = GameObject.Find("Cube_1").transform;
        Cube_2 = GameObject.Find("Cube_2").transform;
        Cube_3 = GameObject.Find("Cube_3").transform;

        line.SetPosition(0, Cube_1.position);
        line.SetPosition(1, Cube_2.position);
        line.SetPosition(2, Cube_3.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
