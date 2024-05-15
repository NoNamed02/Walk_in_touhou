using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Like_value : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = NPCManager.Instance.like.ToString();
    }
}
