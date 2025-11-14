using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int CurrentScore = 0;

    public void IncreaseScore()
    {
        CurrentScore++;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        ScoreText.text = "ќчки: " + CurrentScore.ToString() + " из 10";
    }

    void Start()
    {
        UpdateScoreText();
    }
}