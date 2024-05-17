using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class less_Gold_text : MonoBehaviour
{
    public float maxAlpha = 0.8f; // 최대 투명도

    private Text textComponent; // UI Text 컴포넌트

    public bool isactive = false;

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector3(-135.9999f, 447.9999f, 0f);
        textComponent = GetComponent<Text>();
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
                textComponent.color += new Color(0f, 0f, 0f, 0.01f);
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
                textComponent.color -= new Color(0f, 0f, 0f, 0.01f);
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
