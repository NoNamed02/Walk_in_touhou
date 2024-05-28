using UnityEngine;
using UnityEngine.SceneManagement;

public class goto_reimu : MonoBehaviour
{
    // 버튼을 눌렀을 때 호출되는 함수
    public text_manager text_Manager;
    public GPSManager player;
    public CameraSwitch C;
    public GameObject text_M;
    public AudioSource Sound;
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoTo()
    {
        Sound = GetComponent<AudioSource>();
        Soundmanager.Instance.Playsound("hakurei");
        if(text_Manager.is_First == false)
            text_M.GetComponent<text_manager>().DisplayNextSentence();
        player.ismove = false;
        C.isCameraActive = 4;
    }
}
