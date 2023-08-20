using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// InGameでカウントダウン3秒間は、ウチワと時間経過を止める 
/// </summary>
public class CountDownScript : MonoBehaviour
{
    [SerializeField, Tooltip("カウントダウンを表示するテキスト")] Text _countDownText;
    [SerializeField, Tooltip("ゲーム開始までのカウントダウン")] float _countDownTime = 3f; 
    [Tooltip("ウチワがマウスカーソルを追従するスクリプト")] player_Uchiwa _player_Uchiwa = null; 
    void Start()
    {
        if (!_player_Uchiwa) _player_Uchiwa = FindAnyObjectByType<player_Uchiwa>();
        _countDownText = GetComponent<Text>();
        _countDownText.enabled = true;
        StartCoroutine("CountDown");
    }
    IEnumerator CountDown()
    {
        // 3秒待機 
        for (float i = _countDownTime; i > -1; i--)
        {
            yield return new WaitForSeconds(1); //1秒待つ
            _countDownText.text = i.ToString();
        }
        // 使用可能化  
        _player_Uchiwa.enabled = true;
        GameManager._instance.StartGame = true;
        // テキスト非表示 
        _countDownText.enabled = false;
        yield break;
    }
}
