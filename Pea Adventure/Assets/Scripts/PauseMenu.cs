using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] GameObject pauseMenu;
public static bool beenpressed = false;

void Awake()
{
    Time.timeScale = 1f;
    beenpressed = false;
    pauseMenu.SetActive(false);
}

void Update()
{
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        if(beenpressed)
        {
            Resume1();
        }
        else
        {
            Pause();
        }
        
    }

}

public void Pause()
{
    pauseMenu.SetActive(true);
    Time.timeScale = 0f; //to freeze game
    beenpressed = true;
    Debug.Log("Pressed");
}
public void Restart()
{
    SceneManager.LoadScene("Start Menu");
}

public void Resume1()
{
    pauseMenu.SetActive(false);
    Time.timeScale = 1.0f;
    beenpressed = false;
}


public void Resume2()
{
    Time.timeScale = 1.0f;
    pauseMenu.SetActive(false);

}
}
