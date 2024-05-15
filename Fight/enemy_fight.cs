using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_fight : MonoBehaviour
{
    public float speed = 5f; // 플레이어의 이동 속도
    public float backwardForce = 10000f; // 뒤로 가할 힘

    public float HP = 30;

    private Rigidbody2D rb; // Rigidbody2D 컴포넌트 참조

    void Start()
    {
        StartCoroutine(delay());
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
    }

    void Update()
    {
        if(HP > 0)
            rb.velocity = new Vector2(speed, rb.velocity.y);
        else if(HP <= 0){
            Gamemanager.Instance.iswin = true;
            rb.AddForce((transform.up * backwardForce)/2);
            rb.velocity = new Vector2(-speed*30, rb.velocity.y);
            delay();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 충돌한 객체가 enemy 태그를 가지고 있는 경우
        {
            // 오브젝트의 현재 방향으로 반대 방향으로 힘을 가합니다.
            rb.AddForce(transform.right * backwardForce);
            HP -= Gamemanager.Instance.forced;
        }
    }

    //코루틴
    IEnumerator delay()
    {
        yield return new WaitForSeconds(3);
        Gamemanager.Instance.fightend = true;
    }
}
