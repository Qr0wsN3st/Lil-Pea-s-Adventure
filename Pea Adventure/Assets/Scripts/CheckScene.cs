using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    Animation anim;
    public bool Frightened = false;

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "Level3")
        {
            Debug.Log("Level2");
            Frightened = true;
        }
        if(Frightened == true)
        {
            animator.SetBool("Scared", true);
        }
    }
}
