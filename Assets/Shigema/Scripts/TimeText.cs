using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �c�莞�Ԃ�\�� 
/// �e�L�X�g�ɒ��ڃA�^�b�`���� 
/// 3���\�� 
/// 0�b�ɂȂ�����A���U���g�V�[���֑J�ڂ��� 
/// </summary>
public class TimeText : MonoBehaviour
{
    [Tooltip("���Ԃ�\������e�L�X�g")] Text _text = null;
    [SerializeField, Tooltip("�J�ڂ���V�[����")] string _sceneName = null; 
    float _time = 0f;
    ScoreSave _scoreSave = null; 
    void Start()
    {
        _text = GetComponent<Text>();
        // ������ 
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
