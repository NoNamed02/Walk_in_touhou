using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_btn_control : MonoBehaviour
{
    public GameObject shop_back_btn;
    public shop_control shop;

    void Update(){
        if(shop.shop_menu != 1)
            shop_back_btn.SetActive(true);
        else
            shop_back_btn.SetActive(false);
    }
}
