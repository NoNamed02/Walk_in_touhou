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

    //public AudioSource Sound;

    void Start()
    {
        //Sound = GetComponent<AudioSource>();
        // Collider2D 컴포넌트를 찾아서 monsterCollider 변수에 할당합니다.
        monsterCollider = GetComponent<Collider2D>();
        GameObject move_scenceObject = GameObject.Find("Move_scene");
        if (move_scenceObject != null)
        {
            move_scence = move_scenceObject;
        }

        GameObject cameraswitchObject = GameObject.Find("Cameraswitch");
        if (cameraswitchObject != null)
        {
            cameraswitch = cameraswitchObject.GetComponent<CameraSwitch>();
        }

        GameObject playerObject = GameObject.Find("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<GPSManager>();
        }

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
                //Sound.Play();
                monsterCollider.enabled = false;
                player.ismove = false;
                //move_scence.SetActive(true);
                Vector3 pos = new Vector3(transform.position.x, transform.position.y, -2f);
                Instantiate(move_scence, pos, gameObject.transform.rotation);
                Destroy(gameObject);
            }
        }
    }

}
