using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class monster : MonoBehaviour
{
    private Collider2D monsterCollider; // Monster의 Collider2D 컴포넌트

    public GameObject move_scence;

    public GPSManager player;
    public CameraSwitch cameraswitch;

    void Start()
    {

        // Collider2D 컴포넌트를 찾아서 monsterCollider 변수에 할당합니다.
        monsterCollider = GetComponent<Collider2D>();

        // Collider2D를 찾지 못한 경우 오류 메시지를 표시합니다.
        if (monsterCollider == null)
        {
            Debug.LogError("Collider2D를 찾을 수 없습니다. Monster GameObject에 Collider2D 컴포넌트를 추가하세요.");
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 충돌한 객체가 Player 태그
        {
            if (monsterCollider != null)
            {
                monsterCollider.enabled = false;
                player.ismove = false;
                move_scence.SetActive(true);
            }
        }
    }
}
