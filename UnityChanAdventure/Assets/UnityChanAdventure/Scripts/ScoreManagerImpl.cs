using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManagerImpl : IScoreManager
{
    private int score = 0;
    private List<ScoreItem> scoreItems = new List<ScoreItem>();

    public void AddScore(ScoreItem scoreItem)
    {
        score += scoreItem.GetScore();
        scoreItems.Remove(scoreItem);
        Debug.Log("Score: " + score);
        
        if (scoreItems.Count == 0)
        {
            SceneManager.LoadScene("Result");
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void RegisterScoreItem(ScoreItem scoreItem)
    {
        scoreItems.Add(scoreItem);
    }
}