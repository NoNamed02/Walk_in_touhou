using UnityEngine;
using UnityEngine.SceneManagement;

public class goto_reimu : MonoBehaviour
{
    // 버튼을 눌렀을 때 호출되는 함수
    public void GoToReimuScene()
    {
        SceneManager.LoadScene("Reimu"); // "Reimu" 씬으로 이동
    }
}
