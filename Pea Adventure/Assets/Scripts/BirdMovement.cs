using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float a = 0.6f;
    public float b = 0.5f;

    [SerializeField] AudioSource flap;

    public Animator animator;

    //SAVE THE start position
    private Vector3 startPOS;
    void Start()
    {
        startPOS = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
       flap.Play();
    //to constantly update its posisition 
       transform.position = startPOS + new Vector3(Mathf.Sin(Time.time*a),Mathf.Sin(Time.time)*b, 0.0f);
       
    }
}
