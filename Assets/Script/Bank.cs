using System;
using UnityEngine;

public class Bank
{
    public static event Action<int> ActionScoreAdd;
    public int Score { get; private set; }
    public int BestScore { get => PlayerPrefs.GetInt("BestScore", 0); private set => PlayerPrefs.SetInt("BestScore", (int)value); }

    public void AddScore(int amount)
    {
        Score++;
        
        SetBestScore(Score);

        ActionScoreAdd?.Invoke(Score);
    }
    public int SetBestScore(int amount)
    {
        if (BestScore < amount)
            BestScore = amount;

        return BestScore;
    }
}
