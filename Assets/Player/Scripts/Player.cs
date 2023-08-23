using UnityEngine;

public class Player : MonoBehaviour
{
    public float inputHorizontal;
    public bool isJump;

    [SerializeField] private float speed = 400f;
    [SerializeField] private float jumpForce = 60f;

    [SerializeField] private bool isGrounded;

    private Rigidbody2D rb;
    private SpriteRenderer _spriteRenderer;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    { 
        Grounded();
        PlayerJump();
    }

    private void FixedUpdate()
    {
        PlayerWalk();
        PlayerFlip();
    }

    private void PlayerWalk()
    {
        Vector2 movement = new Vector2(inputHorizontal * speed * Time.deltaTime, rb.velocity.y);

        rb.velocity = movement;
    }

    private void PlayerFlip()
    {
        if (inputHorizontal > 0)
        {
            _spriteRenderer.flipX = false;

        }
        else if (inputHorizontal < 0)
        {
            _spriteRenderer.flipX = true;
        }
    }

    private void PlayerJump()
    {
        if (isGrounded && isJump)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
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

    private void Grounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down);
        Debug.DrawRay(transform.position, Vector2.down * hit.distance, Color.red);

        if(hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.y -  transform.position.y);

            if (distance <= 0.83f)
            {
                isGrounded = true;
            }
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            isGrounded = true;
        } 

        // Сделать через Raycast2d;
    }

    */
}

