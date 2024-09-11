using System;
using DG.Tweening;
using UnityEngine;
using Zenject;

public class ScoreItem : MonoBehaviour, ICollectable
{
    [SerializeField] private int score = 10;

    [Inject] private IScoreManager scoreManager;

    private void Start()
    {
        scoreManager.RegisterScoreItem(this);
        transform.DORotate(new Vector3(0, 360, 0), 1, RotateMode.WorldAxisAdd).SetEase(Ease.InOutCubic).SetLoops(-1);
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