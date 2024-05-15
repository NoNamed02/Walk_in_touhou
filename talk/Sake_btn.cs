using UnityEngine;

public class Sake_btn : MonoBehaviour
{
    public NPCManager NPCManager;
    public DialogueManager dialogueManager;
    public Reimu Reimu;
    void Update() {
        NPCManager = GameObject.FindWithTag("NPCmanager").GetComponent<NPCManager>();
    }
    public void OnButtonClick()
    {
        if(NPCManager.Sake >= 1){
            string[] sentences = new string[] { "선물이야? 고마워!",
                                                "오 제법 괜찮은 술이잖아?",
                                                "잘마실께",
                                                "더 볼일 있어?"};
            NPCManager.like += 10;                  
            dialogueManager.StartDialogue(sentences);
            NPCManager.Sake -= 1;
        }
    }
}
