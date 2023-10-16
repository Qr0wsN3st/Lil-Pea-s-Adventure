using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{  // Start is called before the first frame update
  public void QuitGame()
  {
    Application.Quit();
    Debug.Log("Bye");
  }
}
