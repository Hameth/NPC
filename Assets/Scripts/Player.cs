using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    private float _movement;
    private Rigidbody2D _rb;
    private PauseMenu controlPausa;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        controlPausa = FindObjectOfType<PauseMenu>();
    }

    private void Update()
    {
        _movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _movement;
        _rb.velocity = velocity;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Tip")) return;
        other.enabled = false;
       
        controlPausa.PauseTip(); 
        
    }
}
