using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private GameObject FinishPanel, RestartPanel;
    [SerializeField] private Text LevelNumber, Score;

    private GenerationLevel _generationLevel;

    private void Start()
    {
        _generationLevel = new GenerationLevel();
    }
    private void OnEnable()
    {
        FinishPlatform.ActionFinished += FinishMenu;
        Bank.ActionScoreAdd += SetScore;
    }
    private void OnDisable()
    {
        FinishPlatform.ActionFinished -= FinishMenu;
        Bank.ActionScoreAdd -= SetScore;
    }
    public void SetScore(int ScoreAmount)
    {
        Score.text = "Score: " + ScoreAmount;
    }
    public void FinishMenu()
    {
        Time.timeScale = 0;
        FinishPanel.SetActive(true);
        LevelNumber.text = "Level: ";
    }
    public void NextLevelButton()
    {
        _generationLevel.IncreaseLevel();
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void RestartMenu()
    {
        Time.timeScale = 0;
        RestartPanel.SetActive(true);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
