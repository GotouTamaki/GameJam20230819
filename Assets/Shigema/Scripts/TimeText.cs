using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 残り時間を表示 
/// テキストに直接アタッチする 
/// 3桁表示 
/// </summary>
public class TimeText : MonoBehaviour
{
    [Tooltip("時間を表示するテキスト")] Text _text = null;
    [SerializeField, Tooltip("制限時間")] float _time = 60;
    void Start()
    {
        _text = GetComponent<Text>();
        // 初期化 
        _text.text = "000";
    }

    void Update()
    {
        _time -= Time.deltaTime; 
        _text.text = "Time  " + _time.ToString("000");
    }
}
