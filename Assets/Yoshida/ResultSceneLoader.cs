using UnityEngine;

public class ResultSceneLoader : MonoBehaviour
{
    [SerializeField] float _sceneLoadTime = 5f;
    SceneManager _sceneManager;
    void Start()
    {
        _sceneManager = GetComponent<SceneManager>();
    }
    void Update()
    {
        _sceneLoadTime -= Time.deltaTime;
        if (_sceneLoadTime < 0)
        {
            _sceneManager.SceneChange("Title");
        }
    }
}
