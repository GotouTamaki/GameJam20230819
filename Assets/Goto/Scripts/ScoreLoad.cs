using UnityEngine;

public class ScoreLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {      
        ScoreSave._bestScore = PlayerPrefs.GetInt("BestScore");
    }
}
