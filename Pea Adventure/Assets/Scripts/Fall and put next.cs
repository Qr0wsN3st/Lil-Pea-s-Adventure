using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fallandputnext : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField] AudioSource ripSound;
  public Animator animator;
  Animation anim;

  void Update()
  { 
    if (gameObject.transform.position.y < -15f)
    {
      TP();
    }
  }
  

  public void TP()
  {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
