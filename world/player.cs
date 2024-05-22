using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GPSManager : MonoBehaviour
{
    public float latitude = 0.0f; // 시작 위도를 0으로 설정
    public float longitude = 0.0f; // 시작 경도를 0으로 설정

    private float previousLatitude = 0.0f; // 이전 위도
    private float previousLongitude = 0.0f; // 이전 경도

    public float latitudeChange = 0.0f; // 위도 변화량
    public float longitudeChange = 0.0f; // 경도 변화량

    public float distanceMoved = 0.0f; // 움직인 거리
    public float movementSpeed = 100000.0f;

    public float pos_x = 0.0f;
    public float pos_y = 0.0f;
    public Slider vector_move;

    private bool initialized = false; // 위치 초기화 여부를 추적하는 변수

    public bool ismove = true;

    public bool forced_move = false;

    // 방향 변수
    public int pos_dir = 0; // 0 - y+ / 1 - x+ / 2 - y- / 3 - x-

    //////////////////////////////위에는 전부 좌표 관련////////////////////////////////////////////
    private Animator animator;
    //전투
    public fight_control fight_Control;
    void Start()
    {
        animator = GetComponent<Animator>();
        // 위치 서비스를 시작합니다.
        Input.location.Start();

        // 위치 서비스를 사용할 수 있는지 확인합니다.
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("GPS is not enabled on this device.");
        }
    }

    void Update()
    {
        if(Gamemanager.Instance.player_HP <= 0 && fight_Control.is_start == false)
            Gamemanager.Instance.player_HP = 1; // 체력 0이면 1로 부활
            
        if(Gamemanager.Instance.S_move == true){
            gameObject.transform.position = Gamemanager.Instance.playerPosition;
            Gamemanager.Instance.S_move = false;
        }
        // GPS 값을 업데이트합니다.
        UpdateGPSValues();
        distanceMoved *= Time.deltaTime * movementSpeed;
        
        if(forced_move == true)
            distanceMoved = vector_move.value / 100; // 강제이동 //////////////////////////////////////////////
        Vector3 newPosition = transform.position;

        if(pos_dir == 0){
            animator.SetInteger("move_check", 0);
            newPosition.y += distanceMoved;}
        if(pos_dir == 1){
            animator.SetInteger("move_check", 1);
            newPosition.x += distanceMoved;}
        if(pos_dir == 2){
            animator.SetInteger("move_check", 2);
            newPosition.y -= distanceMoved;}
        if(pos_dir == 3){
            animator.SetInteger("move_check", 3);
            newPosition.x -= distanceMoved;}
        if(ismove)
            transform.position = newPosition;
    }

    void UpdateGPSValues()
    {
        // 위치 서비스가 실행 중이고 정상적인 경우에만 위치 정보를 업데이트합니다.
        if (Input.location.status == LocationServiceStatus.Running)
        {
            // GPS 값을 받아옵니다.
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;

            if (!initialized)
            {
                // 첫 번째 프레임에서의 이전 위치를 현재 위치로 초기화합니다.
                previousLatitude = latitude;
                previousLongitude = longitude;
                initialized = true;
            }

            // 이전 위치와 현재 위치의 차이를 계산합니다.
            latitudeChange = latitude - previousLatitude;
            longitudeChange = longitude - previousLongitude;
            pos_x += latitudeChange;
            pos_y += longitudeChange;

            // 벡터값
            distanceMoved = Mathf.Sqrt(latitudeChange * latitudeChange + longitudeChange * longitudeChange);
            
            // 이전 위치를 현재 위치로 업데이트합니다.
            previousLatitude = latitude;
            previousLongitude = longitude;
        }
        Gamemanager.Instance.playerPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void OnDestroy()
    {
        // 앱이 종료되면 위치 서비스를 중지합니다.
        Input.location.Stop();
    }

    IEnumerator start_rest(){
        yield return new WaitForSeconds(2f);
    }
}