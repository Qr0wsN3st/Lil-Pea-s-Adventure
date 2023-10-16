using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//from tut.

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public float starttime = 360f;
    public bool timerIsRunning = true;
    

    [SerializeField] TMP_Text timerText;
    void Start()
    {
        timerIsRunning= true;
    }
    // Update is called once per frame
    void Update()
    {
        timerText.text = starttime.ToString("0");
        
        if(timerIsRunning)
        {
            if (starttime > 0)
            {
                starttime -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("Lost");
                starttime = 0;
                timerIsRunning = false;
            }
        }
    }
}
