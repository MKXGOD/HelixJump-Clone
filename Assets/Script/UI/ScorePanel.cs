using UnityEngine;
using UnityEngine.UI;

public class ScorePanel : MonoBehaviour
{
    [SerializeField] private Text ScoreText;

    private Bank _bank;

    public void Start()
    {
        _bank = new Bank();
    }

    private void OnEnable()
    {
        Bank.ActionScoreAdd += ScoreValue;
    }
    private void OnDisable()
    {
        Bank.ActionScoreAdd -= ScoreValue;
    }
    private void ScoreValue(int Score)
    {
        ScoreText.text = "" + Score;
    }
}
