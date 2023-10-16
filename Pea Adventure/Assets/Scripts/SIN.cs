using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : MonoBehaviour
{
    // Start is called before the first frame update
    public float a = 3f;
    public float b = 0.5f;
    private Vector3 startPOS;
    public Animator animator;
    
    void Start()
    {
        startPOS = transform.position;
    }

    void Update()
    {
        transform.position = startPOS + new Vector3(0.0f,Mathf.Sin(Time.time*a)*b, 0.0f);
    }
}
