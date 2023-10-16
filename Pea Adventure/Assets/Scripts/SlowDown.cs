using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{

public bool TouchingInk = false;
public PlayerMovement script;
public Animator animator;
Animation anim;

SpriteRenderer Inked;
Color color;

    // Start is called before the first frame update
 private void OnTriggerEnter(Collider collision)
 {
    if(collision.gameObject.CompareTag("Ouch"))
    {
        GetComponent<Fly>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
        TouchingInk = true;
        Inked = GetComponent<SpriteRenderer>();
        Inked.color = new Color(0.21f,0.21f,0.21f,1f);
        animator.SetBool("IsFlying", false);

        Debug.Log("in Ink");
    }
 }

 private void OnTriggerExit(Collider collision)
 {
    if(collision.gameObject.CompareTag("Ouch"))
    {
        TouchingInk = false;

        Debug.Log("No");
    }
 }

 void Start()
 {
    script = GetComponent<PlayerMovement>();
 }

 void Update()
 {
    if(TouchingInk == false)
    {
        normal();
    }
    else if(TouchingInk == true)
    {
        GoSlow();
    }
 }

void GoSlow()
{
    script.movementSpeed = 0.5f;
    script.jumpforce = 1f;
    animator.SetBool("IsFlying", false);
}

void normal()
{
    script.movementSpeed = 3f;
    script.jumpforce = 4f;
    Debug.Log("noraml");
}

}
