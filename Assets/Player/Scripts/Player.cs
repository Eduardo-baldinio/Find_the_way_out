using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 400f;
    public float inputHorizontal;
    [SerializeField] private float jumpForce = 60f;
    [SerializeField] private float gravityForce = -9.81f;

    float deltaY;
    float move;


    private Vector2 movement;

    public bool isJump = false;
    private bool isGrounded;

    private Rigidbody2D rb;
    private SpriteRenderer _spriteRenderer;


    private Vector2 _playerVelocity;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    { 
        Jump();
    }

    private void FixedUpdate()
    {
        if(isGrounded)
        {
            _playerVelocity.y = gravityForce;
        }

        Walk();
    }

    private void Walk()
    {
        Vector2 pos = transform.position;

        movement = new Vector2(inputHorizontal * speed * Time.deltaTime, _playerVelocity.y);
       //move = inputHorizontal * speed * Time.deltaTime;
       //_playerVelocity.x = inputHorizontal * speed * Time.deltaTime;
        
        //rb.velocity = movement;

        rb.MovePosition(pos + movement);

        _playerVelocity.y += gravityForce * Time.deltaTime;

        if (isJump )
        {
            rb.MovePosition(_playerVelocity);
        }

        //rb.MovePosition(pos + _playerVelocity);

        if (inputHorizontal > 0)
        {
            _spriteRenderer.flipX = false;
            
        }
        else if(inputHorizontal < 0)
        {
            _spriteRenderer.flipX = true;
        }
    }

    public void Attack()
    {

    }

    private void TakeDamage(float damageForce)
    {

    }

    private void Die()
    {

    }

    private void Collect()
    {

    }

    private void Jump()
    {
        if (isGrounded && isJump)
        {
            //rb.velocity = new Vector2(move, jumpForce);
            _playerVelocity.y = jumpForce;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            isGrounded = true;
        } 

        // Сделать через Raycast2d;
    }
}

