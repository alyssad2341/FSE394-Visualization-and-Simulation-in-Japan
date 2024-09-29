using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI message;  // Reference to the TMP Text component
    private float elapsedTime;  // Stores the elapsed time in seconds
    private bool isRunning;     // Indicates if the stopwatch is running

    // Start is called before the first frame update
    void Start()
    {
        //elapsedTime = 0f;
        isRunning = true;  // Start the stopwatch automatically
        message = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            // elapsedTime += Time.deltaTime;  // Update elapsed time

            // // Format elapsed time as minutes:seconds:milliseconds
            // int minutes = Mathf.FloorToInt(elapsedTime / 60f);
            // int seconds = Mathf.FloorToInt(elapsedTime % 60f);
            // int milliseconds = Mathf.FloorToInt((elapsedTime * 1000f) % 1000f);

            // // Update the TMP text component
            // stopwatchText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);

            message.text = Time.time.ToString("F2");

        }
    }

    // Call this method to start the stopwatch
    public void StartStopwatch()
    {
        isRunning = true;
    }

    // Call this method to stop the stopwatch
    public void StopStopwatch()
    {
        isRunning = false;
    }

    // Call this method to reset the stopwatch
    public void ResetStopwatch()
    {
        //elapsedTime = 0f;
        isRunning = false;
        //stopwatchText.text = "00:00:000";
    }
}
