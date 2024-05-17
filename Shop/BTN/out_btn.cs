using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class out_btn_shop : MonoBehaviour
{
    public GPSManager player;
    public CameraSwitch C;
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoToWorldcamera()
    {
        player.ismove = true;
        C.isCameraActive = 1;
    }
}
