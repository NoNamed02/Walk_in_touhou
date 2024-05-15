using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight_reset : MonoBehaviour
{
    public GameObject World_UI;
    public GameObject Shop_UI;
    public GPSManager player;

    // Update is called once per frame
    void Update()
    {
        if(player.ismove == true){
            World_UI.SetActive(true);
            Shop_UI.SetActive(false);}
        else{
            World_UI.SetActive(false);
            Shop_UI.SetActive(true);}

        Gamemanager.Instance.iswin = false;
        Gamemanager.Instance.fightend = false;
    }
}
