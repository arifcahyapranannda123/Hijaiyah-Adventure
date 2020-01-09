using UnityEngine;
using System.Collections;
 
public class Player : MonoBehaviour
{

    public float jumpForce;
    public float jumpTime;
    public float jumpTimeCounter;

    public bool grounded;
    public LayerMask whatIsGround;
    public bool stoppedJumping;
 

 
    public Transform groundCheck;
    public float groundCheckRadius;
    private Animator _animator;

    public Rigidbody2D rb;
 
    void Start()
    {
        _animator = this.GetComponent<Animator> ();
        jumpTimeCounter = jumpTime;
    }
 
    void Update()
    {
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
 
 
        if(grounded)
        {
            jumpTimeCounter = jumpTime;
        }
    }
 
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            if(grounded)
            {
                rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
                stoppedJumping = true;
                _animator.SetTrigger ("Jump");
            }
        }
 
        if((Input.GetMouseButton(0)) && !stoppedJumping)
        {
            if(jumpTimeCounter > 0)
            {
                rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }
 
 
        if(Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(4, rb.velocity.y);
            transform.eulerAngles = new Vector3(0, 0, 0);
            _animator.SetTrigger ("Walk");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
            _animator.SetTrigger ("Walk");
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    
    }
}