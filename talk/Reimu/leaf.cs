using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class leaf : MonoBehaviour
{   
    public float maxAlpha = 0.8f; // 최대 투명도
    private Image imageComponent; // UI 이미지 컴포넌트
    public mini_control mini;

    private bool fadingStarted = false;

    void Start()
    {
        imageComponent = GetComponent<Image>();
        float size = Random.Range(0.5f,1.2f);
        float rotation = Random.Range(0f,270f);
        imageComponent.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotation);
        imageComponent.rectTransform.localScale = new Vector3(size, size, 1f);
    }

    void Update()
    {
        if (mini.score >= 20 && !fadingStarted)
        {
            StartCoroutine(FadeImage());
            fadingStarted = true;
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
    }

    public void hit()
    {
        float size = Random.Range(0.5f,1.2f);
        float rotation = Random.Range(0f,270f);
        imageComponent.rectTransform.rotation = Quaternion.Euler(0f, 0f, rotation);
        imageComponent.rectTransform.localScale = new Vector3(size, size, 1f);
        mini.score += 1;
        gameObject.SetActive(false);
    }
}
