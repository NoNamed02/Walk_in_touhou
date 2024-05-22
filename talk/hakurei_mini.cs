using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class hakurei_mini : MonoBehaviour
{
    public mini_control control;
    public GameObject leave1;
    public GameObject leave2;
    public GameObject leave3;
    public GameObject leave4;
    public GameObject leave5;
    public GameObject leave6;
    public GameObject leave7;

    ///////////////////////////////////////////////////////
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("set_active", 0f, 3f);
    }

    void Update()
    {
        if(control.score >= 20){
            NPCManager.Instance.like += 5;
            gameObject.SetActive(false);
        }
    }

    void set_active()
    {
        if(control.score < 20){
            int R = Random.Range(1, 8);
            if (R == 1)
                leave1.SetActive(true);
            else if (R == 2)
                leave2.SetActive(true);
            else if (R == 3)
                leave3.SetActive(true);
            else if (R == 4)
                leave4.SetActive(true);
            else if (R == 5)
                leave5.SetActive(true);
            else if (R == 6)
                leave6.SetActive(true);
            else if (R == 7)
                leave7.SetActive(true);
            }
        }
}
