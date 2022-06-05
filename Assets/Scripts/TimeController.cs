using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    private int second = 0;
    private int min = 0;

    [SerializeField] private Text time;

    private void Update()
    {
        min = Mathf.RoundToInt(Time.deltaTime / 60);
        second = Mathf.RoundToInt(Time.deltaTime % 60);
        time.text = string.Format("Time: {0}:{1}", min.ToString(), second.ToString());
    }
}
