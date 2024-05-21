using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UnityEngine.UI 네임스페이스를 추가합니다.

public class back_g_cs : MonoBehaviour
{
    public mini_control mini;

    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mini.score >= 20)
        {
            StartCoroutine(FadeImage());
        }
        else
            image.color = new Color(1f,1f,1f,1f);
            
        if(image.color.a <= 0)
            gameObject.SetActive(false);
    }

    IEnumerator FadeImage()
    {
        // 이미지 색상을 서서히 변경하는 코루틴입니다.
        while (image.color.a > 0)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - 0.01f);
            yield return new WaitForSeconds(0.1f); // 0.1초마다 실행하여 부드러운 페이드 효과를 줍니다.
        }
    }
}
