using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gold_text : MonoBehaviour
{
    public TextMeshProUGUI Text;
    void Start(){
        Text.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        Text.text = NPCManager.Instance.Gold.ToString();
    }
}
