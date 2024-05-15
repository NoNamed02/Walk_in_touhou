using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class out_btn_shop : MonoBehaviour
{
    public GPSManager player;
    public CameraSwitch cameraswitch;
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoTo()
    {
        player.ismove = true;
        cameraswitch.isCamera1Active = 1;
    }
}
