using UnityEngine;
using UnityEngine.SceneManagement;

public class goto_shop : MonoBehaviour
{
    public GPSManager player;
    public CameraSwitch cameraswitch;
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoTo()
    {
        player.ismove = false;
        cameraswitch.isCamera1Active = 2;
    }
}
