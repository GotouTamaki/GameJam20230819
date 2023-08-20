using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Uchiwa : MonoBehaviour
{
    List<Rigidbody> rigidbodies = new List<Rigidbody>();
    [SerializeField] float _power = 0;
    [Tooltip("仰いだ時に鳴る")] AudioSource _audioSource = null;
    [Tooltip("仰ぐアニメーター")] Animator _animator = null; 

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 左クリックでうちわを仰ぐ
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("isWave");
            _audioSource.PlayOneShot(_audioSource.clip);

            foreach (var rigidbody in rigidbodies)
            {
                rigidbody.AddForce(0, _power, 0, ForceMode.Impulse);                
            }
        }

        // Camera.main でメインカメラ（MainCamera タグの付いた Camera）を取得する
        // Camera.ScreenToWorldPoint 関数で、スクリーン座標をワールド座標に変換する
        Vector3 mousePosition = Input.mousePosition;
        // ターゲットが見えなくなってしまうため、Z 座標を調整している
        mousePosition.z = 10;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void OnTriggerEnter(Collider other)
    {
        rigidbodies.Add(other.gameObject.GetComponent<Rigidbody>());
    }
    private void OnTriggerExit(Collider other)
    {
        rigidbodies.Remove(other.gameObject.GetComponent<Rigidbody>());
    }
}
