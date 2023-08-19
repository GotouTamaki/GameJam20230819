using UnityEngine;
using UnityEngine.UI;

public class ScoreTextManager : MonoBehaviour
{
    [SerializeField] int _myScore = 0;
    [SerializeField] int _bestScore = 0;
    Text _myScoreText;
    Text _bestScoreText;
    void Start()
    {
        _myScore = PlayerPrefs.GetInt("MyScore", _myScore);
        _bestScore = PlayerPrefs.GetInt("BestScore", _myScore);
        _myScoreText = GetComponent<Text>();
        _bestScoreText = GetComponent<Text>();
        _myScoreText.text = $"MyScore\n{_myScore.ToString()}";
        _bestScoreText.text = $"BesthScore\n{_bestScore.ToString()}";
    }
}
