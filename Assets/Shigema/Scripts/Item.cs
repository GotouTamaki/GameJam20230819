using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int _score = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kago")
        {
            AddScore(_score);
        }
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
