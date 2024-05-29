using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_manager : MonoBehaviour
{
    public GameObject World_UI;
    public GameObject Shop_UI;
    public GameObject Fight_UI;
    public GameObject Hakurei_UI;
    public GameObject Marisa_UI;


    public GPSManager player;
    public CameraSwitch C;

    public GameObject txtmanager;

    // Update is called once per frame
    void Update()
    {
        if(player.ismove == true && C.isCameraActive == 1){
            if((!BGMmanager.Instance.Sound.isPlaying || BGMmanager.Instance.sound_name != "Main") && BGMmanager.Instance != null)
                BGMmanager.Instance.Playsound("Main");
            World_UI.SetActive(true);
            Shop_UI.SetActive(false); 
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(false);
            txtmanager.SetActive(false);
            Marisa_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 2){
            World_UI.SetActive(false);
            Shop_UI.SetActive(true);
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(false);
            txtmanager.SetActive(false);
            Marisa_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 3){
            World_UI.SetActive(false);
            Shop_UI.SetActive(false);
            Fight_UI.SetActive(true);
            Hakurei_UI.SetActive(false);
            txtmanager.SetActive(false);
            Marisa_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 4){
            if((!BGMmanager.Instance.Sound.isPlaying || BGMmanager.Instance.sound_name != "Hakurei") && BGMmanager.Instance != null)
                BGMmanager.Instance.Playsound("Hakurei");
            World_UI.SetActive(false);
            Shop_UI.SetActive(false);
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(true);
            txtmanager.SetActive(true);
            Marisa_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 5){
            World_UI.SetActive(false);
            Shop_UI.SetActive(false);
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(false);
            txtmanager.SetActive(false);
            Marisa_UI.SetActive(true);
        }
    }
}

