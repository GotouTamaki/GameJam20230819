using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// スコアを表示 
/// テキストに直接アタッチする 
/// ゲームマネジャーからスコアを取得する
/// 6桁表示
/// </summary>
public class ScoreText : MonoBehaviour
{
    [Tooltip("スコアを表示するテキスト")] Text _text = null;
    [Tooltip("変換する数値")] int _score = 0; 
    void Start()
    {
        _text = GetComponent<Text>();
        // 初期化 
        _text.text = "000000"; 
        _score = 0; 
    }

    void Update()
    {
        _score = GameManager._instance.Score; 
        _text.text = "Score  " + _score.ToString("000000");
    }
}
