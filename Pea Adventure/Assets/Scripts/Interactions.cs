using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    Animation anim;

    [SerializeField] GameObject Pea;
    [SerializeField] GameObject InterBush;

    public GameObject PressEText;
    public GameObject Sack;
    public bool IsInProx = false;
    public bool PressedE = false;
    public bool hasbeenpressed = false;

    public bool initiatedText = false;
    [SerializeField] AudioSource Yay;


    void Update()
    {
        animator.SetBool("E", false);

         float Dist = Vector3.Distance(InterBush.transform.position,Pea.transform.position);
        
        if(Dist < 0.5f && initiatedText == false)
        {
            IsInProx = true;
            initiatedText = true;
            Instantiate(PressEText);
        }

        //hasbeenpressed and third pressed preventative of repeat
        if(Input.GetKeyDown(KeyCode.E) && hasbeenpressed == false)
        {
            PressedE = true;
            hasbeenpressed = true;
        }

        if( PressedE == true && IsInProx == true)
        {
            Debug.Log("It worked lol");
            animator.SetBool("E", true);
            PressedE = false;
            Yay.Play();
            Instantiate(Sack);
            
        }

    }

}
