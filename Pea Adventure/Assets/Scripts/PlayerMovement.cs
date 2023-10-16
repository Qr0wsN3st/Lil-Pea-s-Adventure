using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float movementSpeed = 3f;
    public float jumpforce = 4f;

    [SerializeField] AudioSource jumpSound;

    public bool flipX = false;

    public bool IsGrounded = true;

    public Animator animator;
    Animation anim;



    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<Fly>().enabled = false;
    }
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //Input Manger
        float horizontalInput = Input.GetAxis("Horizontal");
       
        float verticalInput = Input.GetAxis("Vertical");


        //walking

        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
         
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        
        //animation flip
        if(horizontalInput > 0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        else if(horizontalInput < -0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && IsGrounded == true)
        {
            jump();
        }

        if(IsGrounded == false)
        {
            animator.SetBool("IsJumping", true);
        }
        else if(IsGrounded == true)
        {
            animator.SetBool("IsJumping", false);
        }
    }

    void jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpforce, rb.velocity.z);
        IsGrounded = false;
        jumpSound.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Movingplatform"))
        {
            IsGrounded = true;
        }
    }

   
}
