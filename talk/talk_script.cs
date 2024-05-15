using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public NPCManager NPCManager;

    public TMP_Text dialogueText; // 대화 내용을 표시
    public GameObject dialoguePanel; // 대화창을 나타내는 게임 오브젝트
    public Reimu Reimu; // 플레이어 값 가져오는 오브젝트
    public float typingSpeed = 0.1f; // 글자가 나타나는 속도
    public int nextMouseButton = 0; // 마우스 왼쪽 버튼 (0: 왼쪽, 1: 오른쪽, 2: 가운데)

    private string currentSentence; // 현재 대화 문장
    private bool isTyping = false; // 현재 대화가 표시 중인지 여부

    private Queue<string> sentences = new Queue<string>(); // 대화 내용을 저장하는 큐

    // 대화창을 열고 대화를 시작하는 함수
    public void StartDialogue(string[] sentences)
    {
        // 대화창을 활성화합니다.
        dialoguePanel.SetActive(true);

        // 대화 내용을 큐에 추가합니다.
        foreach (string sentence in sentences)
        {
            this.sentences.Enqueue(sentence);
        }

        // 대화를 시작합니다.
        DisplayNextSentence();
    }

    // 다음 대화를 표시하는 함수
    public void DisplayNextSentence()
    {
        // 대화가 표시 중이라면, 현재 문장을 한 번에 표시하고 종료합니다.
        if (isTyping)
        {
            StopAllCoroutines();
            dialogueText.text = currentSentence;
            isTyping = false;
            return;
        }

        // 대화가 더 이상 남아있지 않다면 대화창을 닫습니다.
        /*
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        */

        // 대화문장을 큐에서 가져와서 표시합니다.
        if(sentences.Count != 0){
            currentSentence = sentences.Dequeue();
            StartCoroutine(TypeSentence(currentSentence));
        }
    }

    // 문장을 한 글자씩 표시하는 코루틴
    IEnumerator TypeSentence(string sentence)
    {
        isTyping = true;
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        isTyping = false;
    }

    // 대화를 종료하고 대화창을 닫는 함수
    public void EndDialogue()
    {
        // 대화창을 비활성화합니다.
        dialoguePanel.SetActive(false);
    }

    // 마우스 입력을 감지하여 다음 대화를 표시하는 함수
    private void Update()
    {
        NPCManager = GameObject.FindWithTag("NPCmanager").GetComponent<NPCManager>();
        if(sentences.Count != 0){
            Reimu.talk_last_text = false;
        }
        else if(sentences.Count == 0){
            Reimu.talk_last_text = true;
        }
        if (Input.GetMouseButtonDown(nextMouseButton))
        {
            DisplayNextSentence();
        }
    }
}
