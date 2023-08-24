using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    private int Timer = 0;
    private int TotalTime ;
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI totaltimetext;

    public static bool IsGameStarted = false;

    private void Start()
    {
        IsGameStarted = true;
        Debug.Log(IsGameStarted);
    }

    // Update is called once per frame
    void Update()
    {

        // Updating Timer
        if (Timer < 600)
        {
            Timer++;
            TimerText.text = "TIMER: " + Timer.ToString();
        }

      

        if(Timer == 600)
        {
            IsGameStarted=false;
            Debug.Log(IsGameStarted);
        }

        if(!IsGameStarted)
        {
            TotalTime = Timer;
            totaltimetext.text ="TOTAL TIME: "+TotalTime.ToString();
        }

    }
    public void Restart ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}

