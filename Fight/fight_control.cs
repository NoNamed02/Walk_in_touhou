using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight_control : MonoBehaviour
{
    public GameObject out_btn_fight;

    public GameObject win;
    public GameObject lose;
    
    public GameObject player;
    public GameObject enemy;
    public enemy_fight e;
    public bool is_start = false;

    public AudioSource Sound;

    private bool soundPlayed = false; // 사운드 재생 확인 변수

    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (is_start)
        {
            player.SetActive(true);
            enemy.SetActive(true);
        }
        else
        {
            player.transform.position = new Vector3(-9f, -50f, 0f);
            enemy.transform.position = new Vector3(9f, -50f, 0f);
            e.HP = 30;
            player.SetActive(false);
            enemy.SetActive(false);
        }

        //---------------------------------------------------------//
        if (Gamemanager.Instance.player_HP <= 0)
        {
            if (!soundPlayed)
            {
                Sound.Play();
                soundPlayed = true;
            }
            lose.SetActive(true);
            out_btn_fight.SetActive(true);
        }
        else if (e.HP <= 0)
        {
            if (!soundPlayed)
            {
                Sound.Play();
                soundPlayed = true;
            }
            win.SetActive(true);
            out_btn_fight.SetActive(true);
        }
        else
        {
            win.SetActive(false);
            lose.SetActive(false);
            out_btn_fight.SetActive(false);
            soundPlayed = false;
        }
    }
}
