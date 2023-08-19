using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGeneratorManager : MonoBehaviour
{
    [SerializeField] GameObject _bird = null;
    [SerializeField] float _interval = 1.0f;
    [SerializeField] float _spawnPosiRange = 10f;
    [SerializeField] float _spawnNegaRange = -10f;
    [SerializeField] float _intervalMaxRange = 10f;
    [SerializeField] float _intervalMinRange = 1f;

    Vector3 _spawnPosi = Vector3.zero;
    float _timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _interval)
        {
            _spawnPosi = new Vector3(this.transform.position.x, Random.Range(_spawnNegaRange, _spawnPosiRange), 0);
            Instantiate(_bird, _spawnPosi, Quaternion.identity);
            _timer = 0;
            _interval = Random.Range(_intervalMinRange, _intervalMaxRange);
        }
    }
}
