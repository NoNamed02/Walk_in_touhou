using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_count : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public int iter = 0;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        iter++;
        textMeshProUGUI.text = iter.ToString();
        if(iter == 120)
            iter = 0;
    }
}
