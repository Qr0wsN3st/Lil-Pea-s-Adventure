using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropmov : MonoBehaviour
{
    // Start is called before the first frame update
    public float a = 4f;
    public float b = 0.13f;
    //SAVE THE start position
    private Vector3 startPOS;
    void Start()
    {
        startPOS = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    //to constantly update its posisition 
       transform.position = startPOS + new Vector3(0.0f,Mathf.Sin(Time.time*a)*b, 0.0f);
    }
}
