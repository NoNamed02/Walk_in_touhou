using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_fight : MonoBehaviour
{
    public float speed = 5f; // 플레이어의 이동 속도
    public float backwardForce = 500f; // 뒤로 가할 힘

    private Rigidbody2D rb; // Rigidbody2D 컴포넌트 참조

    void Start()
    {
        StartCoroutine(delay());
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
    }

    void Update()
    {
        if(Gamemanager.Instance.player_HP > 0)
            rb.velocity = new Vector2(speed, rb.velocity.y);
        else if(Gamemanager.Instance.player_HP <= 0){
            Gamemanager.Instance.iswin = false;
            rb.AddForce((transform.up * backwardForce)/2);
            rb.velocity = new Vector2(-speed*30, rb.velocity.y);
            delay();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy")) //
        {
            // 오브젝트의 현재 방향으로 반대 방향으로 힘을 가합니다.
            rb.AddForce(-transform.right * backwardForce);
            Gamemanager.Instance.player_HP -= 5; // 일반 적
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(3);
        Gamemanager.Instance.fightend = true;
    }
}
