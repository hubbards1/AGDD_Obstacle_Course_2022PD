using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer mr = null;
    Rigidbody rb = null;
    
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mr.enabled = false;
    }
    void Update()
    {
        if(Time.time > timeToWait)
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }    
    }

 

