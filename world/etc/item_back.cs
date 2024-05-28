using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class item_back : MonoBehaviour
{
    public float maxAlpha = 0.8f; // 최대 투명도
    private Image imageComponent; // UI 이미지 컴포넌트
    private Color initialColor; // 초기 색상
    public bool isactive = false;

    public float fade_value = 0.05f;
    public GameObject text;

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(0f, -290f, 0f);
        imageComponent = GetComponent<Image>();
        initialColor = new Color(0, 0, 0, 0);
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
            imageComponent.color += new Color(0f, 0f, 0f, fade_value);
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
            imageComponent.color -= new Color(0f, 0f, 0f, fade_value);
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
