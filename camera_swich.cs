using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera1; // 월드
    public Camera camera2; // 상점
    public Camera camera3; // 전투

    public int isCameraActive = 1;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
    }

    void Update()
    {
        if(isCameraActive == 1){
            camera1.enabled = true;
            camera2.enabled = false;
            camera3.enabled = false;

        }
        else if(isCameraActive == 2){
            camera1.enabled = false;
            camera2.enabled = true;
            camera3.enabled = false;
        }
        else if(isCameraActive == 3){
            camera1.enabled = false;
            camera2.enabled = false;
            camera3.enabled = true;
        }
    }
}
