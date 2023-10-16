using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAY : MonoBehaviour
{
    Rigidbody rb;

    public float movementSpeed = 0.5f;
    public bool flipX = false;
    public bool moving = false;

    public Animator animator;
    Animation anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
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
}
