using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Random = System.Random;
public class Activable : MonoBehaviour
{
    [SerializeField] private int inicio;

    [SerializeField] private int final;
    // Start is called before the first frame update
    void Start()
    {
        Generar();
        
    }

    void Generar()
    {
        Random rnd = new Random();
        var value = rnd.Next(inicio, final);
        var value2 = rnd.Next(-2, 2);
        transform.position = new Vector3(value2,value,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
