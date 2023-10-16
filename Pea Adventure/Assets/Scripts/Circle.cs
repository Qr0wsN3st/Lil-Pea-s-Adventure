using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    public float a = 4f;
    public float b = 0.5f;
    public float c = 3;
    public float d = 1f;
    private Vector3 startPOS;
    public Animator animator;
    
    void Start()
    {
        startPOS = transform.position;
    }

    void Update()
    {
        transform.position = startPOS + new Vector3(Mathf.Cos(Time.time*c)*d,Mathf.Sin(Time.time*a)*b, 0.0f);
    }
}
