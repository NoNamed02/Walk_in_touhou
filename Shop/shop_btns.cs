using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_btns : MonoBehaviour
{
    public shop_control shop;
    public void shop_back_btn_(){ // 되돌아가기 버튼
        if(shop.shop_menu != 1)
        shop.shop_menu = 1;
    }
    public void shop_stat(){
        shop.shop_menu = 2;
    }
    public void shop_postion(){
        shop.shop_menu = 3;
    }
    public void shop_like(){
        shop.shop_menu = 4;
    }
}
