using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>制限時間用の時間を測るタイマー</summary>
    [SerializeField, Header("制限時間用の時間を測るタイマー"), Tooltip("制限時間用の時間を測るタイマー")] float _timer = 60f;

    public static GameManager _instance;
    /// <summary>スコア用変数</summary>
    int _score = 0;
    /// <summary>ゲームスタートの判定</summary>
    public bool _startGame = false;

    // Start is called before the first frame update
    void Start()
    {
        //GameManagerが既にあるかを判定する
        if (_instance == null)
        {
            // このオブジェクトはシーンをまたいでも消されない
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
        // ゲームがスタートしたときのみ測る
        if (_startGame) 
        {
            _timer -= Time.deltaTime;
        }
    }

    /// <summary>制限時間用の時間を測るタイマー</summary>
    public float Timer
    {
        get { return _timer; }
        set { _timer = value; }
    }

    /// <summary>スコア用変数</summary>
    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    /// <summary>ゲームスタートの判定</summary>
    public bool StartGame
    {
        get { return _startGame; }
        set { _startGame = value; }
    }
}
