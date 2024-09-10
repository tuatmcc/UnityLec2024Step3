using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    
    [Inject] private IScoreManager scoreManager;
    
    private void Start()
    {
        scoreText.text = "Score: " + scoreManager.GetScore();
    }
}
