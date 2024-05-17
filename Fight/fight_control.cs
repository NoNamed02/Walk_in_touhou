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
    // Update is called once per frame
    void Update()
    {
        if(is_start == true){
            player.SetActive(true);
            enemy.SetActive(true);
        }
        else{
            player.transform.position = new Vector3(-9f, -50f, 0f);
            enemy.transform.position = new Vector3(9f,-50f, 0f);
            e.HP = 30;
            player.SetActive(false);
            enemy.SetActive(false);
        }
    //---------------------------------------------------------//
        if (Gamemanager.Instance.player_HP <= 0)
        {
            lose.SetActive(true);
            out_btn_fight.SetActive(true);
        }
        else if(e.HP <= 0){
            win.SetActive(true);
            out_btn_fight.SetActive(true);
        }
        else
        {
            win.SetActive(false);
            lose.SetActive(false);
            out_btn_fight.SetActive(false);
        }
    }
}
