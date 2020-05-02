using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    [Header("Velocidad de la camara: ")] 
    [SerializeField] private float camaraVel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.up * camaraVel/1000;
        
    }

    
}
