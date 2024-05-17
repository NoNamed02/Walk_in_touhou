using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fight_start_spwan : MonoBehaviour
{
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
    }
}
