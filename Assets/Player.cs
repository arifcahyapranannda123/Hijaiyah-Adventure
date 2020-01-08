using UnityEngine;
using System.Collections;
 
public class Player : MonoBehaviour
{
    /*these floats are the force you use to jump, the max time you want your jump to be allowed to happen,
     * and a counter to track how long you have been jumping*/
    public float jumpForce;
    public float jumpTime;
    public float jumpTimeCounter;
    /*this bool is to tell us whether you are on the ground or not
     * the layermask lets you select a layer to be ground; you will need to create a layer named ground(or whatever you like) and assign your
     * ground objects to this layer.
     * The stoppedJumping bool lets us track when the player stops jumping.*/
    public bool grounded;
    public LayerMask whatIsGround;
    public bool stoppedJumping;
 
    /*the public transform is how you will detect whether we are touching the ground.
     * Add an empty game object as a child of your player and position it at your feet, where you touch the ground.
     * the float groundCheckRadius allows you to set a radius for the groundCheck, to adjust the way you interact with the ground*/
 
    public Transform groundCheck;
    public float groundCheckRadius;
    private Animator _animator;
    //You will need a rigidbody to apply forces for jumping, in this case I am using Rigidbody 2D because we are trying to emulate Mario :)
    public Rigidbody2D rb;
 
    void Start()
    {
        //sets the jumpCounter to whatever we set our jumptime to in the editor
        _animator = this.GetComponent<Animator> ();
        jumpTimeCounter = jumpTime;
    }
 
    void Update()
    {
        //determines whether our bool, grounded, is true or false by seeing if our groundcheck overlaps something on the ground layer
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
 
 
        //if we are grounded...
        if(grounded)
        {
            //the jumpcounter is whatever we set jumptime to in the editor.
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