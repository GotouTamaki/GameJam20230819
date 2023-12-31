using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int _score = 0;
    [SerializeField] float _telepotePosition = - 6.0f;
    [Tooltip("羽が浮きあがる音")] AudioSource _audioSouse = null;
    [SerializeField] AudioClip _se_point = null;
    [SerializeField] AudioClip _se_jump = null;

    void Start()
    {
        if (!_audioSouse) _audioSouse = GetComponent<AudioSource>();
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Uchiwa" && Input.GetMouseButtonDown(0))
        {
            _audioSouse.PlayOneShot(_se_jump);
            Debug.Log("jump");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kago")
        {
            _audioSouse.PlayOneShot(_se_point);
            AddScore(_score);
            this.transform.position = new Vector3(0, _telepotePosition, 0);
        }
    }
    /// <summary>
    /// スコア加算 
    /// </summary>
    /// <param name="value">追加する値</param>
    void AddScore(int value)
    {
        GameManager._instance.Score += value;
    }
}
