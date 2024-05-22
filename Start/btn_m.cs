using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_m : MonoBehaviour
{
    public Button start_btn;
    public Button out_btn;
    public GameObject loading;
    // Start is called before the first frame update
    void Start()
    {
        loading.SetActive(false);
        start_btn.onClick.AddListener(on_start);
        out_btn.onClick.AddListener(on_exit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void on_start(){
        loading.SetActive(true);
    }

    void on_exit(){
        Application.Quit();
    }
}
