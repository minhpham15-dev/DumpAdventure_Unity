using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    private int second = 0;
    private int min = 0;

    private string secondString = "";
    private string minString = "";

    private float totalTime = 0;

    [SerializeField] private Text time;

    private void Update()
    {
        totalTime += Time.deltaTime;
        min = Mathf.RoundToInt(totalTime / 60);
        second = Mathf.RoundToInt(totalTime % 60);

        minString = min < 10 ? String.Format("0{0}", min) : min.ToString();
        secondString = second < 10 ? String.Format("0{0}", second) : second.ToString();
        time.text = string.Format("Time: {0}:{1}", minString, secondString);
    }
}
