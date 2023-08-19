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
    /// スコア加算 
    /// </summary>
    /// <param name="value">追加する値</param>
    public void AddScore(int value)
    {
        GameManager._instance.Score += value;
    }
}
