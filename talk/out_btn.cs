using UnityEngine;
using UnityEngine.SceneManagement;

public class out_btn : MonoBehaviour
{
    public NPCManager NPCManager;
    public DialogueManager dialogueManager;
    public Reimu Reimu;

    void Update() {
        NPCManager = GameObject.FindWithTag("NPCmanager").GetComponent<NPCManager>();
    }
    public void OnButtonClick()
    {
        Reimu.Out = true;
        string[] sentences = new string[] { "어, 벌써 가는거야",
                                            "그래, 잘가 다음에 보자"};              
        dialogueManager.StartDialogue(sentences);
        
        // LoadSceneDelayed 메서드를 2초 뒤에 호출
        if(Reimu.talk_last_text == true)
            Invoke("LoadSceneDelayed", 2f);
    }

    // 지연된 LoadScene을 실행하는 메서드
    void LoadSceneDelayed()
    {
        SceneManager.LoadScene("Play");
    }
}
