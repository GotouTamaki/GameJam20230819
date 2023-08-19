using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1.0f;
    [SerializeField] float _telepotePosition = 0.0f;
    Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.AddForce(_moveSpeed, 0, 0, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wing")
        {
            other.transform.position = new Vector3(0, _telepotePosition, 0);
        }
    }
}
