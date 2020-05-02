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
    [SerializeField] private GameObject componente1;
    [SerializeField] private GameObject componente2;
    [SerializeField] private GameObject componente3;
    [SerializeField] private GameObject componente4;
    [SerializeField] private GameObject componente5;
    [SerializeField] private GameObject componente6;
    [SerializeField] private GameObject componente7;
    [SerializeField] private GameObject componente8;
    [SerializeField] private GameObject componente9;
    [SerializeField] private GameObject componente10;
    private List<GameObject> componentes = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        pausa = false;
        GenerarNivel();
        
    }



    void GenerarNivel()
    {
       
        Random rnd = new Random();
        
        componentes.Add(componente1);
        componentes.Add(componente2);
        componentes.Add(componente3);
        componentes.Add(componente4);
        componentes.Add(componente5);
        componentes.Add(componente6);
        componentes.Add(componente7);
        componentes.Add(componente8);
        componentes.Add(componente9);
        componentes.Add(componente10);
        for (int i = 0; i < 10; i++)
        {
            
            var value = rnd.Next(0, contador);
            int pos = i * 10;
            
            componentes[value].gameObject.transform.position  = new Vector3(-25,pos,0);
                
            componentes.RemoveAt(value);

            contador = contador - 1;
            
        }
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
