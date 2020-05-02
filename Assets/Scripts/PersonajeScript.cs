using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonajeScript : MonoBehaviour
{
    [SerializeField] private int fuerzaSalto;
    private Rigidbody2D rb2d;
    private GameManager controlPausa;
    [SerializeField] private string escena;
    [SerializeField] private int velocidadMov;

    private bool finJ = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        controlPausa = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("floor") && rb2d.velocity.y <= 0)
        {
            rb2d.AddForce(Vector2.up * (fuerzaSalto * 100));
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("SampleScene");
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("floor"))
        {
            BoxCollider2D boxCollider = other.gameObject.GetComponent<BoxCollider2D>();
            boxCollider.offset = Vector2.zero;
        }

        if (other.gameObject.CompareTag("Tip"))
        {

            controlPausa.pausa = true;
            other.enabled = false;
        }

        if (other.gameObject.CompareTag("Fin"))
        {
            SceneManager.LoadScene(escena);
            //Llamar escena trivia



        }
    }

    private void Update()
    {
        

        
    }

    


// Update is called once per frame
   
    void FixedUpdate()
    {
        
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                if (touch.position.x < Screen.width / 2)
                {
                    
                    transform.position += Vector3.left * velocidadMov /1000;
                }
                else
                {
                    transform.position += Vector3.right * velocidadMov /1000;
                }

            }
            
    

        
            
        if (Input.GetAxis("Horizontal") < 0)
            transform.position += Vector3.left * velocidadMov /1000;
        
        if (Input.GetAxis("Horizontal") > 0 ) 
            transform.position += Vector3.right * velocidadMov /1000;
    }
}
