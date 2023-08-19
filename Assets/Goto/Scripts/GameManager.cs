using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _timer = 60;

    public static GameManager _instance;
    int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager�����ɂ��邩�𔻒肷��
        if (_instance == null)
        {
            // ���̃I�u�W�F�N�g�̓V�[�����܂����ł�������Ȃ�s
            _instance = this;
        }
        else
        {
            // ���ɂ���Ȃ�Destroy����
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
