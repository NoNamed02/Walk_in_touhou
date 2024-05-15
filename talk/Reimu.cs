using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reimu : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public NPCManager NPCManager;
    public GameObject btn_talk;
    public GameObject btn_out;
    public GameObject btn_Sake;
    public int text_check;
    public bool talk_last_text = false;

    public bool Out = false;

    void Start()
    {
        int randomNumber = Random.Range(1, 6);
        text_check = 0;
        if(NPCManager.Instance.like == 0){ // 첫 조우
            string[] sentences = new string[] { "?",
                                                "넌 처음 보는데, 누구야?",
                                                "방랑자라고? 뭐야 그게",
                                                "난 하쿠레이 레이무, 이 신사의 무녀야",
                                                "뭐, 요괴나 곤란한 일 있으면 찾아오라고",
                                                "술같은 거라도 들고오면 환영해줄께" };
            dialogueManager.StartDialogue(sentences);
            NPCManager.Instance.like++;
            text_check ++;
        }
        else if(NPCManager.Instance.like >= 1){
            string[] sentences = new string[] { "뭐야, 너야?",
                                                "여기에 와봤자 아무것도 없다고",
                                                "청소하기 어려우니까 그냥 가주면 좋겠는데 말이야",
                                                "어쨌든, 뭔가 볼일 있어?" };
            dialogueManager.StartDialogue(sentences);
            text_check ++;
        }
    }

    // Update 함수에서 대화가 끝났는지를 확인하여 버튼을 활성화합니다.
    void Update()
    {
        Gamemanager.Instance.S_move = true;
        NPCManager = GameObject.FindWithTag("NPCmanager").GetComponent<NPCManager>();
        if(talk_last_text == true && text_check == 1 && Out == false){
            btn_Sake.SetActive(true);
            btn_talk.SetActive(true);
            btn_out.SetActive(true);
        }
        else if(talk_last_text == false){
            btn_Sake.SetActive(false);
            btn_talk.SetActive(false);
            btn_out.SetActive(false);
        }
    }
}
