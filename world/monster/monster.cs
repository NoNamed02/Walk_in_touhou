using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class monster : MonoBehaviour
{
    public Gamemanager gamemanager;
    public GameObject Move_scencePrefab; // 이동할 씬을 나타내는 프리팹
    public string canvasTag = "Canvas"; // Canvas 태그 이름

    private GameObject canvasObject; // Canvas GameObject

    void Start()
    {
        // Canvas를 찾아서 canvasObject 변수에 할당합니다.
        canvasObject = GameObject.FindGameObjectWithTag(canvasTag);
        
        // Canvas를 찾지 못한 경우 오류 메시지를 표시합니다.
        if (canvasObject == null)
        {
            Debug.LogError("Canvas를 찾을 수 없습니다. Canvas GameObject에 " + canvasTag + " 태그를 지정하세요.");
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canvasObject != null) // 충돌한 객체가 Player 태그를 가지고 있고 Canvas가 할당된 경우
        {
            GameObject moveScene = Instantiate(Move_scencePrefab, canvasObject.transform);
            RectTransform rectTransform = moveScene.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = Vector2.zero; // Canvas의 중앙에 위치하도록 설정
            Destroy(gameObject);
        }
    }
}
