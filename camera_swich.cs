using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera1; // 월드
    public Camera camera2; // 상점
    public Camera camera3; // 전투
    public Camera camera4; // 미연시 레이무
    public Camera camera5; // 미연시 마리사

    public int isCameraActive = 1;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
    }

    void Update()
    {
        if(isCameraActive == 1){
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
        }
        else if(isCameraActive == 2){
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = false;
        }
        else if(isCameraActive == 3){
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
            camera4.enabled = false;
            camera5.enabled = false;
        }
        else if(isCameraActive == 4){
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = true;
            camera5.enabled = false;
        }
        else if(isCameraActive == 5){
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = false;
            camera4.enabled = false;
            camera5.enabled = true;
        }
    }
}
