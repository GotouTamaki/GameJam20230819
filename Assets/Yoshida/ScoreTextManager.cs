using UnityEngine;
using UnityEngine.UI;

public class ScoreTextManager : MonoBehaviour
{
    [SerializeField] int _myScore = 0;
    [SerializeField] int _highScore = 0;
    Text _myScoreText;
    Text _highScoreText;
    void Start()
    {
        _myScore = PlayerPrefs.GetInt(tag, _myScore);
        _highScore = PlayerPrefs.GetInt(tag + 1, _highScore);
        _myScoreText = GetComponent<Text>();
        _highScoreText = GetComponent<Text>();
        _myScoreText.text = $"MyScore\n{_myScore.ToString()}";
        _highScoreText.text = $"HighScore\n{_highScore.ToString()}";
    }
}
