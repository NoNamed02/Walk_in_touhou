using UnityEngine;
public class NPCManager : MonoBehaviour
{
    private static NPCManager _instance;
    public static NPCManager Instance { get { return _instance; } }

    public int like = 0; // 호감도
    public int Gold = 0; // 골드
    public int Sake = 100; // 레이무 호감작용 아이템

    

    private void Awake()
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
