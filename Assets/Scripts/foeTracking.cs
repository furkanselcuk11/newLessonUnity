using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class foeTracking : MonoBehaviour
{
    public NavMeshAgent foe;
    Transform player;
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per fram
    void Update()
    {
        foe.destination=player.position; // Nesneyi takip eder
    }
}
