using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>�������ԗp�̎��Ԃ𑪂�^�C�}�[</summary>
    [SerializeField, Header("�������ԗp�̎��Ԃ𑪂�^�C�}�["), Tooltip("�������ԗp�̎��Ԃ𑪂�^�C�}�[")] float _timer = 60f;

    public static GameManager _instance;
    /// <summary>�X�R�A�p�ϐ�</summary>
    int _score = 0;
    /// <summary>�Q�[���X�^�[�g�̔���</summary>
    public bool _startGame = false;

    // Start is called before the first frame update
    void Start()
    {
        //GameManager�����ɂ��邩�𔻒肷��
        if (_instance == null)
        {
            // ���̃I�u�W�F�N�g�̓V�[�����܂����ł�������Ȃ�
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
        // �Q�[�����X�^�[�g�����Ƃ��̂ݑ���
        if (_startGame) 
        {
            _timer -= Time.deltaTime;
        }
    }

    /// <summary>�������ԗp�̎��Ԃ𑪂�^�C�}�[</summary>
    public float Timer
    {
        get { return _timer; }
        set { _timer = value; }
    }

    /// <summary>�X�R�A�p�ϐ�</summary>
    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    /// <summary>�Q�[���X�^�[�g�̔���</summary>
    public bool StartGame
    {
        get { return _startGame; }
        set { _startGame = value; }
    }
}
