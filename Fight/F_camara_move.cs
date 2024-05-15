using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_camara_move : MonoBehaviour
{
    Camera mainCamera; // 카메라 참조
    public float targetSize = 10f; // 변경할 크기
    public float duration = 2f; // 변경에 걸리는 시간

    void Start()
    {
        Gamemanager.Instance.S_move = true;
        mainCamera = Camera.main; // 메인 카메라 참조
        Invoke("ChangeCameraSize", duration); // ChangeCameraSize 메서드를 duration 이후에 호출
    }

    void ChangeCameraSize()
    {
        // 카메라 크기를 targetSize로 변경하는 애니메이션 실행
        StartCoroutine(ChangeSizeAnimation(mainCamera, mainCamera.orthographicSize, targetSize, duration));
    }

    IEnumerator ChangeSizeAnimation(Camera camera, float startSize, float targetSize, float duration)
    {
        float timer = 0f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / duration); // 보간된 시간 계산 (0 ~ 1)

            // 카메라 크기를 보간하여 변경
            camera.orthographicSize = Mathf.Lerp(startSize, targetSize, t);

            yield return null; // 다음 프레임까지 대기
        }
    }
}
