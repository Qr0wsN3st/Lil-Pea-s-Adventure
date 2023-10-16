using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float movementSpeed = 3f;
    public bool flipX = false;

    [SerializeField] AudioSource FlyingSound;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
      void Update()
    {
        //in short cut unity already included
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float z = 0f;

        rb.velocity = new Vector3(x*movementSpeed, y*movementSpeed, z);
        
        //animation flip
        if(x > 0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            FlyingSound.Play();
        }

        else if(x < -0.01f)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            FlyingSound.Play();
        }
    }
   
}
