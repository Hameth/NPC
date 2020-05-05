using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    private float _movement;
    private Rigidbody2D _rb;
    private PauseMenu controlPausa;

    public Joystick joystick;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Input.gyro.enabled = true;
        controlPausa = FindObjectOfType<PauseMenu>();
    }

    private void Update()
    {
        _movement = joystick.Horizontal * movementSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _movement;
        _rb.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Finish")))
        {
            SceneManager.LoadScene("Trivia");
        }

        if (!other.gameObject.CompareTag("Tip")) return;
        other.gameObject.SetActive(false);
        controlPausa.PauseTip();
    }
}