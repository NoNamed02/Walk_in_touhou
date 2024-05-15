using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private static Gamemanager _instance;
    public static Gamemanager Instance { get { return _instance; } }

    /// <summary>
    /// 전투 관련 함수들
    /// </summary>
    public float player_HP = 100;
    public float maxHP = 100; //* 최대 체력
    public float forced = 5;
    public bool iswin = false;
    public bool fightend = false;

    /// <summary>
    /// 월드 관련 변수들
    /// </summary>
    public Vector3 playerPosition; // 플레이어의 위치를 저장하는 변수
    public bool S_move = false;

    void Awake()
    {
        // 인스턴스가 아직 없는 경우 현재 객체를 할당합니다.
        if (_instance == null)
        {
            _instance = this;
        }
        // 이미 인스턴스가 있는 경우 해당 객체를 파괴합니다.
        else
        {
            Destroy(gameObject);
        }
        // 씬 전환 시에도 파괴되지 않도록 설정합니다.
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {

    }

    void Update()
    {
    }
}
