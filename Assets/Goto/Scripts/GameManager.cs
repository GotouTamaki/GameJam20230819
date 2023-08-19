using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _timer = 60;

    public static GameManager _instance;
    int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //GameManagerが既にあるかを判定する
        if (_instance == null)
        {
            // このオブジェクトはシーンをまたいでも消されないs
            _instance = this;
        }
        else
        {
            // 既にあるならDestroyする
            GameObject.Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
    }

    public float Timer
    {
        get { return _timer; }
        set { _timer = value; }
    }

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    
}
