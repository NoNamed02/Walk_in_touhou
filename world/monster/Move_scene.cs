using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class move_scence : MonoBehaviour
{
    public float maxAlpha = 1f; // 최대 투명도
    private Image imageComponent; // UI 이미지 컴포넌트
    public bool isactive = false;
    
    public fight_control fight;
    public CameraSwitch C;

    void Start()
    {
        imageComponent = GetComponent<Image>();
        GameObject fightObject = GameObject.Find("spwan-f_c");
        if (fightObject != null)
        {
            fight = fightObject.GetComponent<fight_control>();
        }
        GameObject cameraswitchObject = GameObject.Find("Cameraswitch");
        if (cameraswitchObject != null)
        {
            C = cameraswitchObject.GetComponent<CameraSwitch>();
        }
    }

    void Update()
    {
        if (!isactive && imageComponent.color.a < maxAlpha)
        {
            isactive = true;
            StartCoroutine(FadeImage());
        }

        if(imageComponent.color.a >= maxAlpha){
            fight.is_start = true;
            C.isCameraActive = 3;
            isactive = false;
            imageComponent.color = new Color(0,0,0,0);
            gameObject.SetActive(false);
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
    }
}

