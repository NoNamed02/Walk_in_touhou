using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class view_like : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = NPCManager.Instance.like.ToString();
    }
}
