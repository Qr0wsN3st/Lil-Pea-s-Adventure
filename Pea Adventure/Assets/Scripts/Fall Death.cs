using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fall : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField] AudioSource ripSound;
  public Animator animator;
  Animation anim;

  void Update()
  { 
    if (gameObject.transform.position.y < -10f)
    {
      Die();
    }
  }
  

  void Die()
  {
    //changed to SpriteRenderer
    animator.SetBool("IsDead", true );
    ripSound.Play();
    GetComponent<Rigidbody>().isKinematic = true;
    GetComponent<PlayerMovement>().enabled = false;
    Invoke(nameof(Reloadlevel), 1f);
  }


  void Reloadlevel ()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
