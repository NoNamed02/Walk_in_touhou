using UnityEngine;
using UnityEngine.SceneManagement;

public class goto_shop : MonoBehaviour
{
    public GPSManager player;
    public CameraSwitch C;
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoTo()
    {
        player.ismove = false;
        C.isCameraActive = 2;
    }
}
