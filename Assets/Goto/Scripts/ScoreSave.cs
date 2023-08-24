using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    int _myScore = 0;
    public static int _bestScore { get; set; } = 0;

    public void Save() 
    {
        _myScore = GameManager._instance.Score;
        PlayerPrefs.SetInt("MyScore", _myScore);

        if (_bestScore < 0)
        {
            _bestScore = 0;
        }

        if (_bestScore < _myScore)
        {
            _bestScore = _myScore;
        }
       
        PlayerPrefs.SetInt("BestScore", _bestScore);

        Debug.Log($"スコア {_myScore}");
        Debug.Log($"ベストスコア {_bestScore}");
    }
}
