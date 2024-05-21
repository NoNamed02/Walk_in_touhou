using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_manager : MonoBehaviour
{
    public GameObject World_UI;
    public GameObject Shop_UI;
    public GameObject Fight_UI;
    public GameObject Hakurei_UI;
    public GPSManager player;
    public CameraSwitch C;

    // Update is called once per frame
    void Update()
    {
        if(player.ismove == true && C.isCameraActive == 1){
            World_UI.SetActive(true);
            Shop_UI.SetActive(false); 
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 2){
            World_UI.SetActive(false);
            Shop_UI.SetActive(true);
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 3){
            World_UI.SetActive(false);
            Shop_UI.SetActive(false);
            Fight_UI.SetActive(true);
            Hakurei_UI.SetActive(false);
        }
        else if(player.ismove == false && C.isCameraActive == 4){
            World_UI.SetActive(false);
            Shop_UI.SetActive(false);
            Fight_UI.SetActive(false);
            Hakurei_UI.SetActive(true);
        }
    }
}

