using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    
    private float _movement;
    private float _dirX;
    private Rigidbody2D _rb;
    
    private PauseMenu _controlPausa;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _dirX = Input.acceleration.x * _movement * movementSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_dirX, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Finish")))
        {
            SceneManager.LoadScene("Trivia");
        }
        if (!other.gameObject.CompareTag("Tip")) return;
        other.gameObject.SetActive(false);
        _controlPausa.PauseTip(); 
        
    }
}
