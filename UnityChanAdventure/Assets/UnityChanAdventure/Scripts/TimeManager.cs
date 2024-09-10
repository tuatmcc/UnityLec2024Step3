using System.Collections;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    
    private float time = 0;
    private bool counting = true;
    
    private void Start()
    {
        TimeCount().Forget();
    }

    private void Destroy()
    {
        counting = false;
    }

    private async UniTask TimeCount()
    {
        while (counting)
        {
            await UniTask.Delay(1000);
            time++;
            timeText.text = "Time: " + time;
        }
    }
}