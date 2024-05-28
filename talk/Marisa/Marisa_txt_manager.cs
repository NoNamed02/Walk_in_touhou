using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mrisa_text_manager : MonoBehaviour
{
    public TextAsset txt;
    string[,] Sentence;
    int rowSize, colSize;

    public Text Name;
    public Text chat;
    public Button dialogueButton;
    public Button exitButton;
    public int currentLine = 0;

    public CameraSwitch C;
    public GPSManager player;

    public bool istalk = false;
    public int last_string;
    public bool is_First = true;
    //public reimu_ani reimu;

    // Start is called before the first frame update
    void Start()
    {
        istalk = true;
        Name.GetComponent<Text>();
        chat.GetComponent<Text>();
        dialogueButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);

        // 버튼 클릭 이벤트 설정
        dialogueButton.onClick.AddListener(OnDialogueButtonClick);
        exitButton.onClick.AddListener(OnExitButtonClick);

        string currentText = txt.text.Trim(); 
        string[] lines = currentText.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries); 
        
        rowSize = lines.Length;
        colSize = lines[0].Split('\t').Length;

        Sentence = new string[rowSize, colSize];


        for (int i = 0; i < rowSize; i++)
        {
            string[] columns = lines[i].Split('\t');
            for (int j = 0; j < colSize; j++)
            {
                if (j < columns.Length)
                {
                    Sentence[i, j] = columns[j];
                }
                else
                {
                    Sentence[i, j] = "";
                }
                Debug.Log(i + "," + j + "," + Sentence[i, j]);
            }
        }
        
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < colSize; j++)
            {
                Debug.Log(i + "," + j + "," + Sentence[i, j]);
            }
        }
        //DisplayNextSentence();
        strar_chat();
    }

    void strar_chat(){
        if(NPCManager.Instance.like == 0){
            currentLine = 1;
            chat.text = Sentence[currentLine, 2];
            DisplayNextSentence();
            }
        else if(NPCManager.Instance.like < 50){
            currentLine = 8;
            chat.text = Sentence[currentLine, 2];
            DisplayNextSentence();
            }
        else if(NPCManager.Instance.like >= 50){
            currentLine = 47;
            chat.text = Sentence[currentLine, 2];
            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    {
        if (currentLine < rowSize)
        {
            Soundmanager.Instance.Playsound("talk");
            Name.text = Sentence[currentLine, 1];
            chat.text = Sentence[currentLine, 2];

            // like_up이 1인 경우 like 변수 증가
            if (Sentence[currentLine, 3] == "1" && istalk == true)
            {
                NPCManager.Instance.like++;
                istalk = false;
            }

            if (Sentence[currentLine, 5] == "1")
            {
                dialogueButton.gameObject.SetActive(true);
                exitButton.gameObject.SetActive(true);
            }
            else
            {
                dialogueButton.gameObject.SetActive(false);
                exitButton.gameObject.SetActive(false);
            }

            //애니메이션//
            /*
            if (Sentence[currentLine, 7] == "1")
                reimu.ani = 1;
            else if(Sentence[currentLine, 7] == "2")
                reimu.ani = 2;
            else if(Sentence[currentLine, 7] == "3")
                reimu.ani = 3;
            else if(Sentence[currentLine, 7] == "4")
                reimu.ani = 4;
            */
            if(Sentence[currentLine+1,2]!="end"){
                currentLine++;
            }
            
            if(Sentence[currentLine,4]=="1"){
                StartCoroutine(chat_out());
            }
        }
    }

    void OnDialogueButtonClick()
    {
        if(NPCManager.Instance.like < 50){
        Debug.Log("Dialogue button clicked!");
            int R = Random.Range(1,7);
            if(R == 1)
                currentLine = 16;
            else if(R == 2)
                currentLine = 19;
            else if(R == 3)
                currentLine = 22;
            else if(R == 4)
                currentLine = 25;
            else if(R == 5)
                currentLine = 28;
            else if(R == 6)
                currentLine = 33;
        }
        else if(NPCManager.Instance.like >= 50){
            int R = Random.Range(1,7);
            if(R == 1)
                currentLine = 54;
            else if(R == 2)
                currentLine = 58;
            else if(R == 3)
                currentLine = 62;
            else if(R == 4)
                currentLine = 65;
            else if(R == 5)
                currentLine = 68;
            else if(R == 6)
                currentLine = 51;
        }

        DisplayNextSentence();
        istalk = true;

    }

    void OnExitButtonClick()
    {
        Debug.Log("Exit button clicked!");
        currentLine = last_string;
        DisplayNextSentence();
        dialogueButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && C.isCameraActive == 5)
        {
            DisplayNextSentence();
        }
        
    }

    IEnumerator chat_out(){
        yield return new WaitForSeconds(2f);
        C.isCameraActive = 1;
        player.ismove = true;
        if(NPCManager.Instance.like <=0){
            currentLine = 1;
            chat.text = Sentence[currentLine, 2];
        }
        else if(NPCManager.Instance.like < 50 && NPCManager.Instance.like > 0){
            currentLine = 8;
            chat.text = Sentence[currentLine, 2];
        }
        else if(NPCManager.Instance.like >= 50){
            currentLine = 47;
            chat.text = Sentence[currentLine, 2];
        }
    }
}