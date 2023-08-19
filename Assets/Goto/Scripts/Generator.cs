using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] List<GameObject> _fallObjects = new List<GameObject>();
    [SerializeField] float _interval = 1.0f;
    [SerializeField] float _spawnPosiRange = 10f;
    [SerializeField] float _spawnNegaRange = -10f;
    [SerializeField] float _intervalPosiRange = 10f;
    [SerializeField] float _intervalNegaRange = 1f;

    Vector3 _spawnPosi = Vector3.zero;
    float _timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        _timer = _interval;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _interval)
        {
            _spawnPosi = new Vector3(Random.Range(_spawnNegaRange, _spawnPosiRange), this.transform.position.y, 0);
            Instantiate(_fallObjects[Random.Range(0, _fallObjects.Count)], _spawnPosi, Quaternion.identity);
            _timer = 0;
            _interval = Random.Range(_intervalNegaRange, _intervalPosiRange);
        }        
    }
}
