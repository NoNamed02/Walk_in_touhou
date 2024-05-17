using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightmanager : MonoBehaviour
{
    public GameObject win;
    public GameObject lose;
    
    public GameObject back_btn;
    // Start is called before the first frame update
    /*
    void Start()
    {
        StartCoroutine(back());
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamemanager.Instance.fightend == true && Gamemanager.Instance.iswin == true){
            win.SetActive(true);
        }
        else if(Gamemanager.Instance.fightend == true && Gamemanager.Instance.iswin == false){
            lose.SetActive(true);
        }
    }

    IEnumerator back()
    {
        yield return new WaitForSeconds(5);
        back_btn.SetActive(true);
    }
    */
}
