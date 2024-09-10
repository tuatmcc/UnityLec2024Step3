using System;
using UnityEngine;
using Zenject;

public class ScoreItem : MonoBehaviour, ICollectable
{
    [SerializeField] private int score = 10;

    [Inject] private IScoreManager scoreManager;

    private void Start()
    {
        scoreManager.RegisterScoreItem(this);
    }

    public void Collect()
    {
        scoreManager.AddScore(this);
        Destroy(gameObject);
    }
    
    public int GetScore()
    {
        return score;
    }
}