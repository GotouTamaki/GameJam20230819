using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KagoManager : MonoBehaviour
{
    [SerializeField] float _telepotePosition = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wing")
        {
            other.transform.position = new Vector3(0, _telepotePosition, 0);
        }
    }
}
