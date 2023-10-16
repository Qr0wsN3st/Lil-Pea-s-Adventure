using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] AudioSource bro;
    public bool IsMoving = false;

    public float speed = 1.5f;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(Time.deltaTime*speed,0.0f,0.0f);
        IsMoving = true;

        if(IsMoving == true)
        {
            bro.Play();
        }
    }

}
