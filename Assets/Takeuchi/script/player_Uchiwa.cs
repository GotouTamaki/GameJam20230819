using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Uchiwa : MonoBehaviour
{
    List<Rigidbody> rigidbodies = new List<Rigidbody>();
    [SerializeField] float _power = 0;

    // Update is called once per frame
    void Update()
    {
        // ���N���b�N�ł��������
        if (Input.GetMouseButtonDown(0))
        {
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
