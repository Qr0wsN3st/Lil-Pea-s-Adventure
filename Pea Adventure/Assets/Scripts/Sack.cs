using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sack : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    Animation anim;

    public GameObject chase;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Sack"))
        {
            Destroy(other.gameObject);
            Debug.Log("Touched sack");
            GetComponent<Fly>().enabled = true;
            GetComponent<PlayerMovement>().enabled = false;
            animator.SetBool("IsFlying", true);
            Instantiate(chase);
            
        }
    }
}
