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
    [Tooltip("�ϊ����鐔�l")] int _score = 0; 
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
}
