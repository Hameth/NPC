using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quiz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Prueba");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("entro");
        SceneManager.LoadScene("Prueba");
    }
}
