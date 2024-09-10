using System;
using System.Collections;
using System.Threading;
using Cysharp.Threading.Tasks;
using R3;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private int time = 0;
    private CancellationTokenSource cts;
    
    private void Start()
    {
        cts = new CancellationTokenSource();
        timeText = GetComponent<TextMeshProUGUI>();
        
        Observable.Interval(TimeSpan.FromSeconds(1.0f), cts.Token)
            .Subscribe(_ =>
            {
                time++;
                timeText.text = "Time: " + time;
                Debug.Log("Time: " + time);
            });
    }
    
    private void OnDestroy()
    {
        Debug.Log("TimeManager OnDestroy");
        cts.Cancel();
    }
}