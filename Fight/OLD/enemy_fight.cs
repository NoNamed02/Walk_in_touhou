using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_fight : MonoBehaviour
{
    public AudioSource Sound;
    public float speed = 5f; // 플레이어의 이동 속도
    public float backwardForce = 10000f; // 뒤로 가할 힘

    public float HP = 30;

    private Rigidbody2D rb; // Rigidbody2D 컴포넌트 참조

    void Start()
    {
        Sound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        if(HP > 0)
            rb.velocity = new Vector2(speed, rb.velocity.y);
        else if(HP <= 0){
            Gamemanager.Instance.iswin = true;
            rb.AddForce((transform.up * backwardForce)/2);
            rb.velocity = new Vector2(-speed*30, rb.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 충돌한 객체가 enemy 태그를 가지고 있는 경우
        {
            Sound.Play();
            // 오브젝트의 현재 방향으로 반대 방향으로 힘을 가합니다.
            rb.AddForce(transform.right * backwardForce);
            HP -= Gamemanager.Instance.power;
        }
    }
}
