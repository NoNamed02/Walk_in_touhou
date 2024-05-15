using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_control : MonoBehaviour
{
    public int shop_menu = 1; // 기본 메뉴
    public GameObject main_btn;
    public GameObject stat_btn;
    public GameObject potion_btn;
    public GameObject like_item_btn;
    // Update is called once per frame
    void Update()
    {
        if(shop_menu == 1){ // 메인
            main_btn.SetActive(true);
            stat_btn.SetActive(false);
            potion_btn.SetActive(false);
            like_item_btn.SetActive(false);
        }
        else if(shop_menu == 2){ // 스탯 상점
            main_btn.SetActive(false);
            stat_btn.SetActive(true);
            potion_btn.SetActive(false);
            like_item_btn.SetActive(false);
        }
        else if(shop_menu == 3){ // 포션 상점
            main_btn.SetActive(false);
            stat_btn.SetActive(false);
            potion_btn.SetActive(true);
            like_item_btn.SetActive(false);
        }
        else if(shop_menu == 4){ // 호감도 상점
            main_btn.SetActive(false);
            stat_btn.SetActive(false);
            potion_btn.SetActive(false);
            like_item_btn.SetActive(true);
        }
    }
}
