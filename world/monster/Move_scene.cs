using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move_scene : MonoBehaviour
{
    public float fadeInDuration = 2f; // 페이드 인에 걸리는 시간
    private float currentAlpha = 0f; // 현재 알파 값

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(FadeIn());
    }

    void Update()
    {
        if (currentAlpha >= 1f)
        {
            ChangeScene();
            Destroy(gameObject);
        }
    }

    IEnumerator FadeIn()
    {
        while (currentAlpha < 1f)
        {
            currentAlpha += Time.deltaTime / fadeInDuration;
            image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
            yield return null;
        }
    }

    void ChangeScene()
    {
        // 씬을 변경하는 코드를 여기에 추가하세요.
        // 예를 들어 SceneManager.LoadScene()을 사용할 수 있습니다.
        SceneManager.LoadScene("Fight");
    }
}
