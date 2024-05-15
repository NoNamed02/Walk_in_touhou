using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class item_back : MonoBehaviour
{
    public float maxAlpha = 0.8f; // 최대 투명도
    public float fadeDuration = 2f; // 페이드 지속 시간

    private Image imageComponent; // UI 이미지 컴포넌트
    private Color initialColor; // 초기 색상
    private Color targetColor; // 목표 색상
    private float startTime; // 시작 시간
    public bool isactive = false;

    public GameObject text;

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(0f, -290f, 0f);
        imageComponent = GetComponent<Image>();
        initialColor = new Color(0, 0, 0, 0);
        targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, maxAlpha); // 목표 투명도 설정
    }

    void Update()
    {
        if (!isactive && imageComponent.color.a < maxAlpha)
        {
            isactive = true;
            text.SetActive(true);
            StartCoroutine(FadeImage());
        }
    }

    IEnumerator FadeImage()
{
    while (true)
    {
        if (imageComponent.color.a < maxAlpha)
        {
            imageComponent.color += new Color(0f, 0f, 0f, 0.001f);
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
            imageComponent.color -= new Color(0f, 0f, 0f, 0.001f);
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
    isactive = false;
}
}
