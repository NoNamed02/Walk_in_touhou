using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class less_gold : MonoBehaviour
{
    public float maxAlpha = 0.8f; // 최대 투명도
    private Image imageComponent; // UI 이미지 컴포넌트
    public bool isactive = false;

    public GameObject text;

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(-136f, 411f, 0f);
        imageComponent = GetComponent<Image>();
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
        isactive = false;
    }
}
