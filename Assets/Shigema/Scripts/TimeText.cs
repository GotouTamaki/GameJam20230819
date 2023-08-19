using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �c�莞�Ԃ�\�� 
/// �e�L�X�g�ɒ��ڃA�^�b�`���� 
/// 3���\�� 
/// </summary>
public class TimeText : MonoBehaviour
{
    [Tooltip("���Ԃ�\������e�L�X�g")] Text _text = null;
    [SerializeField, Tooltip("��������")] float _time = 60;
    void Start()
    {
        _text = GetComponent<Text>();
        // ������ 
        _text.text = "000";
    }

    void Update()
    {
        _time -= Time.deltaTime; 
        _text.text = "Time  " + _time.ToString("000");
    }
}
