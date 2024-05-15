using UnityEngine;
using TMPro; // TMP를 사용하기 위해 추가해야 합니다.

public class YourScript : MonoBehaviour
{
    public GPSModule gpsModule; // GPSModule 스크립트에 접근하기 위한 변수
    public TextMeshProUGUI textMeshProUGUI;
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        // GPSModule 스크립트에서 위치 정보를 가져와서 사용합니다.
        GetLocationInfo();
    }

    void GetLocationInfo()
    {
        // GPSModule 스크립트의 GetLocation 메서드를 사용하여 위치 정보를 얻습니다.
        LocationServiceStatus status;
        float latitude, longitude, altitude;
        bool success = gpsModule.GetLocation(out status, out latitude, out longitude, out altitude);

        // 위치 정보를 성공적으로 가져왔는지 확인합니다.
        if (success)
        {
            Debug.Log("Latitude: " + latitude + ", Longitude: " + longitude + ", Altitude: " + altitude);
            textMeshProUGUI.text = "Latitude: " + latitude + "\nLongitude: " + longitude;
        }
        else
        {
            Debug.Log("Failed to get location information. Status: " + status);
            textMeshProUGUI.text = "False";
        }
    }
}
