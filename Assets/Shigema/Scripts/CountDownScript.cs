using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// InGame�ŃJ�E���g�_�E��3�b�Ԃ́A�E�`���Ǝ��Ԍo�߂��~�߂� 
/// </summary>
public class CountDownScript : MonoBehaviour
{
    [SerializeField, Tooltip("�J�E���g�_�E����\������e�L�X�g")] Text _countDownText;
    [SerializeField, Tooltip("�Q�[���J�n�܂ł̃J�E���g�_�E��")] float _countDownTime = 3f; 
    [Tooltip("�E�`�����}�E�X�J�[�\����Ǐ]����X�N���v�g")] player_Uchiwa _player_Uchiwa = null; 
    void Start()
    {
        if (!_player_Uchiwa) _player_Uchiwa = FindAnyObjectByType<player_Uchiwa>();
        _countDownText = GetComponent<Text>();
        _countDownText.enabled = true;
        StartCoroutine("CountDown");
    }
    IEnumerator CountDown()
    {
        // 3�b�ҋ@ 
        for (float i = _countDownTime; i > -1; i--)
        {
            yield return new WaitForSeconds(1); //1�b�҂�
            _countDownText.text = i.ToString();
        }
        // �g�p�\��  
        _player_Uchiwa.enabled = true;
        GameManager._instance.StartGame = true;
        // �e�L�X�g��\�� 
        _countDownText.enabled = false;
        yield break;
    }
}
