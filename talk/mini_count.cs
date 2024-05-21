using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mini_count : MonoBehaviour
{
    public TextMeshProUGUI text;
    public mini_control mini;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "모은 낙엽 수 : " + mini.score.ToString();
    }
}
