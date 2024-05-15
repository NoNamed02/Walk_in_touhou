using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UITextTransparency : MonoBehaviour
{
    public float maxAlpha = 0.8f; // 최대 투명도
    public float fadeDuration = 2f; // 페이드 지속 시간

    private Text textComponent; // UI Text 컴포넌트
    private Color initialColor; // 초기 색상
    private Color targetColor; // 목표 색상

    public bool isactive = false;

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(0f, -290f, 0f);
        textComponent = GetComponent<Text>();
        initialColor = new Color(1f, 1f, 1f, 0f);
        targetColor = new Color(initialColor.r, initialColor.g, initialColor.b, maxAlpha);
    }

    void Update()
    {
        if (!isactive && textComponent.color.a < maxAlpha)
        {
            isactive = true;
            StartCoroutine(FadeText());
        }
    }

    IEnumerator FadeText()
    {
        while (true)
        {
            if (textComponent.color.a < maxAlpha)
            {
                textComponent.color += new Color(0f, 0f, 0f, 0.001f);
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
            if (textComponent.color.a >= 0)
            {
                textComponent.color -= new Color(0f, 0f, 0f, 0.001f);
            }
            else
            {
                textComponent.color = new Color(textComponent.color.r, textComponent.color.g, textComponent.color.b, 0f);
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
        isactive = false;
    }
}
