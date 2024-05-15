using UnityEngine;
using TMPro;

public class gps_pos_text : MonoBehaviour
{
    public GPSManager gpsManager; // GPSManager 스크립트에 접근하기 위한 변수
    public TextMeshProUGUI textMeshProUGUI; // UI Text To Mesh 오브젝트에 대한 참조

    void Start()
    {
        // TextMeshProUGUI 컴포넌트를 찾아서 참조합니다.
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();

        // GPSManager 스크립트의 인스턴스를 가져옵니다.
        gpsManager = FindObjectOfType<GPSManager>();
    }

    void Update()
    {
        // GPSManager 스크립트에서 위도와 경도 값을 가져와서 UI에 출력합니다.
        if (gpsManager != null)
        {
            textMeshProUGUI.text = "Latitude: " + gpsManager.latitude.ToString() + "\nLongitude: " + gpsManager.longitude.ToString();
        }
    }
}
