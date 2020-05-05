using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject time;
    public bool pausa  ;
    
    [SerializeField]private int tiempoPausa;
    public GameObject camera;
    public int contador = 9;
    public GameObject menuPausa; 
    
    // Start is called before the first frame update
    void Start()
    {
        pausa = false;
        
    }



   

    

    public void Pausar()
    {
           var position = camera.transform.position;
           position.z = 1;
            menuPausa.transform.position = position;

           Time.timeScale = 0.0f;


           if (Input.touchCount <= 0 && !Input.anyKeyDown) return;
           pausa = false;
           Time.timeScale = 1.0f;
           menuPausa.transform.position = new Vector3(50,50,0);





    }
    // Update is called once per frame
    public void Update()
    {
        if (pausa)
        {
            Pausar();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene("SampleScene");
            
        }
    }
   
    

 
}
