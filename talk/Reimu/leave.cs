using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class leave : MonoBehaviour
{   
    public float maxAlpha = 0.8f; // 최대 투명도
    private Image imageComponent; // UI 이미지 컴포넌트
    public mini_control mini;

    void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FadeImage());
        if (mini.score >= 20)
        {
            StartCoroutine(FadeImage());
        }
        if(imageComponent.color.a <= 0)
            gameObject.SetActive(false);
    }
    IEnumerator FadeImage()
    {
        while (true)
        {
            if (imageComponent.color.a < maxAlpha)
            {
                imageComponent.color += new Color(0f, 0f, 0f, 0.01f);
            }
            else
            {
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        while (true)
        {
            if (imageComponent.color.a >= 0)
            {
                imageComponent.color -= new Color(0f, 0f, 0f, 0.01f);
            }
            else
            {
                imageComponent.color = new Color(imageComponent.color.r, imageComponent.color.g, imageComponent.color.b, 0f);
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

    public void hit(){
        mini.score += 1;
        gameObject.SetActive(false);
    }
    IEnumerator _FadeImage()
    {
        // 이미지 색상을 서서히 변경하는 코루틴입니다.
        while (imageComponent.color.a > 0)
        {
            imageComponent.color = new Color(imageComponent.color.r, imageComponent.color.g, imageComponent.color.b, imageComponent.color.a - 0.01f);
            yield return new WaitForSeconds(0.1f); // 0.1초마다 실행하여 부드러운 페이드 효과를 줍니다.
        }
    }
}
