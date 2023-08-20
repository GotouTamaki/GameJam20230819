using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Uchiwa : MonoBehaviour
{
    List<Rigidbody> rigidbodies = new List<Rigidbody>();
    [SerializeField] float _power = 0;
    [Tooltip("�������ɖ�")] AudioSource _audioSource = null;
    [Tooltip("���A�j���[�^�[")] Animator _animator = null; 

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        // ���N���b�N�ł��������
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger("isWave");
            _audioSource.PlayOneShot(_audioSource.clip);

            foreach (var rigidbody in rigidbodies)
            {
                rigidbody.AddForce(0, _power, 0, ForceMode.Impulse);                
            }
        }

        // Camera.main �Ń��C���J�����iMainCamera �^�O�̕t���� Camera�j���擾����
        // Camera.ScreenToWorldPoint �֐��ŁA�X�N���[�����W�����[���h���W�ɕϊ�����
        Vector3 mousePosition = Input.mousePosition;
        // �^�[�Q�b�g�������Ȃ��Ȃ��Ă��܂����߁AZ ���W�𒲐����Ă���
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
