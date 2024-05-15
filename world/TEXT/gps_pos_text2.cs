using UnityEngine;
using TMPro; // TMP를 사용하기 위해 추가해야 합니다.

public class gps_pos_text2 : MonoBehaviour
{
    public GPSManager gpsManager; // GPSManager 스크립트에 접근하기 위한 변수

    public TextMeshProUGUI textMeshProUGUI; // UI Text To Mesh 오브젝트에 대한 참조

    // Start is called before the first frame update
    void Start()
    {
        // TextMeshProUGUI 컴포넌트를 찾아서 참조합니다.
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // GPSManager 스크립트에서 위도와 경도 값을 가져와서 UI에 출력합니다.
        textMeshProUGUI.text = "X: " + gpsManager.pos_x.ToString() + "\nY: " + gpsManager.pos_y.ToString() +"\nVector: " + gpsManager.distanceMoved.ToString();
    }
}
