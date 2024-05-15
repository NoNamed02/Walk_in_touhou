using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class test_script : MonoBehaviour
{
    public RawImage map;
    public GPSManager gpsManager; // GPSManager 스크립트에 접근하기 위한 변수

    [Header("맵 정보")]
    public string strBaseURL = "";
    public int zoom = 20;
    public int mapw;
    public int maph;
    public string strAPIkey = "";

    private double previousLatitude; // 이전 위도
    private double previousLongitude; // 이전 경도

    // Start is called before the first frame update
    void Start()
    {
        map = GetComponent<RawImage>();
        StartCoroutine(Loadmap());
        // 초기 위치 설정
        previousLatitude = gpsManager.latitude;
        previousLongitude = gpsManager.longitude;
    }

    // Update is called once per frame
    void Update()
    {
        // 이전 위치와 현재 위치가 다를 경우에만 Loadmap() 호출
        if (gpsManager.latitude != previousLatitude || gpsManager.longitude != previousLongitude)
        {
            StartCoroutine(Loadmap());
            // 이전 위치 업데이트
            previousLatitude = gpsManager.latitude;
            previousLongitude = gpsManager.longitude;
        }
    }

    IEnumerator Loadmap()
    {
        // GPSManager 스크립트에서 가져온 latitude와 longitude 값을 사용하여 URL 생성
        string url = strBaseURL + "center=" + gpsManager.latitude + "," + gpsManager.longitude + "&zoom=" + zoom.ToString() + "&size=" + mapw.ToString() + "x" + maph.ToString() + "&key=" + strAPIkey;
        Debug.Log("URL : " + url);
        Debug.Log(gpsManager.latitude + "  " + gpsManager.longitude);
        url = UnityWebRequest.UnEscapeURL(url); // URL에 대한 Web 요청
        UnityWebRequest req = UnityWebRequestTexture.GetTexture(url); // Texture를 가져오기 위한 Web 요청

        yield return req.SendWebRequest(); // 요청 전송
        map.texture = DownloadHandlerTexture.GetContent(req); // 요청된 내용을 RawImage에 출력
    }
}
