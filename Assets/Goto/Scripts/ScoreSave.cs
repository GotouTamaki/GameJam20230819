using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    int _myScore = 0;
    static int _bestScore = 0;

    public void Save() 
    {
        _myScore = GameManager._instance.Score;

        if (_bestScore < 0)
        {
            _bestScore = 0;
        }

        if (_bestScore < _myScore)
        {
            _bestScore = _myScore;
        }

        PlayerPrefs.SetInt("MyScore", _myScore);
        PlayerPrefs.SetInt("BestScore", _bestScore);    
    }
}
