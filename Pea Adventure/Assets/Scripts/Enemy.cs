using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour

{

  [SerializeField] AudioSource ripSound;

  public Animator animator;
  Animation anim;
  private void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.CompareTag("Enemy Body"))
    {
        Inked();
    }
  }

  void Inked()
  {
    animator.SetBool("IsDead", true );
    ripSound.Play();
    GetComponent<Rigidbody>().isKinematic = true;
    GetComponent<PlayerMovement>().enabled = false;
    GetComponent<Fly>().enabled = false;
    Invoke(nameof(Reloadlevel), 1.3f);
  }

  void Reloadlevel ()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
