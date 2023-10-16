using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EAPmovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Pea;
    [SerializeField] GameObject Eap;
    [SerializeField] float Speed = 1f;



    public Animator animator;
    Animation anim;

    public bool IsInProx = false;
    [SerializeField] AudioSource shlorgSound;

    // Update is called once per frame
    void Update()
    //Eaps position gets updated to move toward Playeer
    {
        

        float Dist = Vector3.Distance(Eap.transform.position,Pea.transform.position);

        if(Dist < 5f)
        {
            animator.SetBool("IsChasing", true);
            IsInProx = true;
            Gucci();
        }
        else if(Dist > 5f)
        {
            animator.SetBool("IsChasing", false);
            IsInProx = false;
        }

        if(Eap.transform.position.y < -10f)
        {
            Destroy(Eap);
        }
       
    }

    void Gucci()
    {
        if(IsInProx == true)
        {
            shlorgSound.Play();
            Eap.transform.position = Vector3.MoveTowards(Eap.transform.position,Pea.transform.position, Speed*Time.deltaTime); 
        }
    }
    
}
