using Assets.Scripts;
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

    [SerializeField] private Text time;

    private TimeManager timeManager = TimeManager.Instance;

    private void Update()
    {
        timeManager.time += Time.deltaTime;
        min = Mathf.RoundToInt(timeManager.time / 60);
        second = Mathf.RoundToInt(timeManager.time % 60);

        minString = min < 10 ? String.Format("0{0}", min) : min.ToString();
        secondString = second < 10 ? String.Format("0{0}", second) : second.ToString();
        time.text = string.Format("Time: {0}:{1}", minString, secondString);
    }
}
