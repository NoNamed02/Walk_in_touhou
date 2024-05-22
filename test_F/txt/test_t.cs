using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_t : MonoBehaviour
{
    public TextAsset txt;
    string[,] Sentence;
    int rowSize, colSize;

    // Start is called before the first frame update
    void Start()
    {
        string currentText = txt.text.Trim();  // 마지막 줄바꿈 문자를 제거합니다.
        string[] lines = currentText.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);  // 각 줄을 분리합니다.
        
        rowSize = lines.Length;
        colSize = lines[0].Split('\t').Length;

        Sentence = new string[rowSize, colSize];

        for (int i = 0; i < rowSize; i++)
        {
            string[] columns = lines[i].Split('\t');
            for (int j = 0; j < colSize; j++)
            {
                // 인덱스가 맞지 않는 경우를 대비하여 검사합니다.
                if (j < columns.Length)
                {
                    Sentence[i, j] = columns[j];
                }
                else
                {
                    Sentence[i, j] = ""; // 빈 값으로 초기화
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
    }

    // Update is called once per frame
    void Update()
    {
    }
}
