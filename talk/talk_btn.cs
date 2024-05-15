using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public NPCManager NPCManager;
    public DialogueManager dialogueManager;
    public Reimu Reimu;
    
    void Update() {
        NPCManager = GameObject.FindWithTag("NPCmanager").GetComponent<NPCManager>();
    }

    public void OnButtonClick()
    {
        int T = Random.Range(1,5);
        if(NPCManager.Instance.like < 100){
            if(T == 1){
                string[] sentences = new string[] { "뭐? 나하고 이야기하고 싶다고?",
                                                    "그렇게 재미있는 이야기는 없는데 말이야"};
                NPCManager.like++;                  
                dialogueManager.StartDialogue(sentences);
            }
            else if(T == 2){
                string[] sentences = new string[] { "매일 매일 청소해도 항상 낙엽이 쌓여버려",
                                                    "그냥 가만히 둬도 똑같지 않을까?"};
                NPCManager.like++;                  
                dialogueManager.StartDialogue(sentences);
            }
            else if(T == 3){
                string[] sentences = new string[] { "생각해 보니, 너 환상향이 처음이었지?",
                                                    "그럼, 마리사에게 가보는 걸 추천해",
                                                    "마리사도 너와 같은 인간이니까 뭔가 해줄 수 있지 않을까?",
                                                    "나도 인간 아니냐고? 뭐, 나는 논외니까 말이야"};
                NPCManager.like++;                  
                dialogueManager.StartDialogue(sentences);
            }
            else if(T == 4){
                string[] sentences = new string[] { "숲으로 들어갈 때는 조심해",
                                                    "요즘 이상한 괴물들이 많이 생겨났다는 소문이 많더라고",
                                                    "슬라임이라던가? 그런 게 왜 환상량에 생겨난 거지?",
                                                    "뭐, 그러니 제대로 준비라도 하고 들어가는 걸 추천할게"};
                NPCManager.like++;                  
                dialogueManager.StartDialogue(sentences);
            }
        }
    }
}
