using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSave : MonoBehaviour
{
    int _myScore = 0;
    int _1stScore = 0;
    int _2ndScore = 0;
    int _3rdScore = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save() 
    {
        if(_1stScore < _myScore)
        {
            _1stScore = _myScore;
        }
        else if (_2ndScore < _myScore)
        {
            _2ndScore = _myScore;
        }
        else if (_3rdScore < _myScore) 
        {
            _3rdScore = _myScore;
        }
    }
}
