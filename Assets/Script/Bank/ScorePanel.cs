using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _bestScoreText;
    private void OnEnable()
    {
        Bank.ActionScoreAdd += SetScoreText;
        Bank.ActionBestScoreAdd += BestScoreText;
    }
    private void OnDisable()
    {
        Bank.ActionScoreAdd -= SetScoreText;
        Bank.ActionBestScoreAdd -= BestScoreText;
    }
    private void Start()
    {
        BestScoreText(PlayerPrefs.GetInt("BestScore"));
    }
    private void SetScoreText(int score)
    {
        _scoreText.text = "" + score;  
    }
    private void BestScoreText(int bestScore)
    {
        _bestScoreText.text = "Best: " + bestScore;
    }
}
