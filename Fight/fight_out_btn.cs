using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight_out_btn : MonoBehaviour
{
    public GPSManager player;
    public CameraSwitch C;
    public fight_control fight_control;
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoToWorldcamera()
    {
        fight_control.is_start = false;
        player.ismove = true;
        C.isCameraActive = 1;
    }
}
