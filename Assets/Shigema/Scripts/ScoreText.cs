using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �X�R�A��\�� 
/// �e�L�X�g�ɒ��ڃA�^�b�`���� 
/// �Q�[���}�l�W���[����X�R�A���擾����
/// 6���\��
/// </summary>
public class ScoreText : MonoBehaviour
{
    [Tooltip("�X�R�A��\������e�L�X�g")] Text _text = null;
    [Tooltip("�ϊ����鐔�l")] float _score = 0; 
    void Start()
    {
        _text = GetComponent<Text>();
        // ������ 
        _text.text = "000000"; 
        _score = 0; 
    }

    void Update()
    {
        _score = GameManager._instance.Score; 
        _text.text = "Score  " + _score.ToString("000000");
    }

    /// <summary>
    /// �X�R�A���Z 
    /// </summary>
    /// <param name="value">�ǉ�����l</param>
    public void AddScore(int value)
    {
       GameManager._instance.Score += value; 
    }
}
