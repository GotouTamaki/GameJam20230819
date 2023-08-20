using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 残り時間を表示 
/// テキストに直接アタッチする 
/// 3桁表示 
/// 0秒になったら、リザルトシーンへ遷移する 
/// </summary>
public class TimeText : MonoBehaviour
{
    [Tooltip("時間を表示するテキスト")] Text _text = null;
    [SerializeField, Tooltip("遷移するシーン名")] string _sceneName = null; 
    float _time = 0f;
    ScoreSave _scoreSave = null; 
    void Start()
    {
        _text = GetComponent<Text>();
        // 初期化 
        _text.text = "000";
        _scoreSave = FindAnyObjectByType<ScoreSave>();
    }

    void Update()
    {
        _time = GameManager._instance.Timer; 
        _text.text = "Time  " + _time.ToString("000");
        if (_time <= 0)
        {
            _scoreSave.Save();
            UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName);
        }
    }
}
