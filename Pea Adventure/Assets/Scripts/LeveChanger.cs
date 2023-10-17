using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame updat

    // Update is called once per frame
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Next but make it short please")
        {   
            FadeToLevel();
            Debug.Log("Yay");
        }
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
    }
}
