using UnityEngine;
using System.Collections;

public class move_scence_2rd : MonoBehaviour
{
    public float maxAlpha = 1f; // 최대 투명도
    private SpriteRenderer Sprite;
    public bool isactive = false;
    
    public fight_control fight;
    public CameraSwitch C;

    public AudioSource sound;

    void Start()
    {
        sound.Play();
        sound = GetComponent<AudioSource>();
        Sprite = GetComponent<SpriteRenderer>();
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
        if (!isactive && Sprite.color.a < maxAlpha)
        {
            isactive = true;
            StartCoroutine(FadeImage());
        }

        if (Sprite.color.a >= maxAlpha)
        {
            fight.is_start = true;
            C.isCameraActive = 3;
            isactive = false;
            //Sprite.color = new Color(0, 0, 0, 0);
            StartCoroutine(Des());
        }
    }

    IEnumerator FadeImage()
    {
        while (true)
        {
            if (Sprite.color.a < maxAlpha)
            {
                Sprite.color += new Color(0f, 0f, 0f, 0.05f);
            }
            else
            {
                break;
            }
            yield return null;
        }
    }

    IEnumerator Des()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
