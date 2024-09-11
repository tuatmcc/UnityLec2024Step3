using System;
using System.Collections;
using System.Threading;
using R3;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private int time = 0;
    
    private void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();

        Observable.Interval(TimeSpan.FromSeconds(1.0f))
            .Subscribe(_ =>
            {
                time++;
                timeText.text = time + " 秒経過";
            })
            .AddTo(this);
    }
}