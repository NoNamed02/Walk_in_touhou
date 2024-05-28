using UnityEngine;

public class marisa_house : MonoBehaviour
{
    public GameObject button; // 버튼 GameObject를 저장할 변수

    // 충돌이 시작될 때 호출되는 함수
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 충돌한 객체가 Player 태그를 가지고 있는 경우
        {
            //Debug.Log("마리사집 충돌");
            if(button != null) // 버튼이 유효한 경우에만 실행
            {
                button.SetActive(true); // 버튼을 활성화
            }
        }
    }

    // 충돌이 종료될 때 호출되는 함수
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 충돌한 객체가 Player 태그를 가지고 있는 경우
        {
            if(button != null) // 버튼이 유효한 경우에만 실행
            {
                button.SetActive(false); // 버튼을 비활성화
            }
        }
    }
}
