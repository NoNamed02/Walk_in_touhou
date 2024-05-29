using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class hakurei_mini : MonoBehaviour
{
    public Button start_btn;
    public GameObject main;
    public GameObject start_btn_;

    public Button out_btn;
    public GameObject out_text;
    public GameObject out_btn_;
    public back_g_cs bg;

    private bool is_start = false;

    private float timer = 0f;
    public float interval = 3f;

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
        start_btn.onClick.AddListener(minigamestart);
        out_btn.onClick.AddListener(minigameend);
        //InvokeRepeating("set_active", 0f, 3f);
    }
    void minigamestart(){
        is_start = true;
    }
    void minigameend(){
        if(control.score >= 20){
            bg.is_end = true;
            NPCManager.Instance.like += 5;
            is_start = false;
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(!is_start){
            main.SetActive(true);
            start_btn_.SetActive(true);
            out_text.SetActive(false);
            out_btn_.SetActive(false);
        }
        else{
            main.SetActive(false);
            start_btn_.SetActive(false);
            timer += Time.deltaTime;
            if(timer >= interval){
                set_active();
                timer = 0;
            }
        }
        if(control.score >= 20){
            out_text.SetActive(true);
            out_btn_.SetActive(true);
        }
        /*
        if(control.score >= 20){
            NPCManager.Instance.like += 5;
            is_start = false;
            gameObject.SetActive(false);
        }
        */
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
