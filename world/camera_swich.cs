using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public int isCamera1Active = 1;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if(isCamera1Active == 1){
            camera1.enabled = true;
            camera2.enabled = false;
        }
        else if(isCamera1Active == 2){
            camera1.enabled = false;
            camera2.enabled = true;
        }
    }
}
