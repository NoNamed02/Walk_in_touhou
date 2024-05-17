using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat_btn : MonoBehaviour
{
    public GameObject less_gold;
    // Start is called before the first frame update
    public void up_power()
    {
        if(NPCManager.Instance.Gold >= 10){
            NPCManager.Instance.Gold -= 10;
            Gamemanager.Instance.power += 1;
        }
        else if(NPCManager.Instance.Gold < 10){
            less_gold.SetActive(true);
        }
    }
    public void up_defense()
    {
        if(NPCManager.Instance.Gold >= 10){
            NPCManager.Instance.Gold -= 10;
            Gamemanager.Instance.defense += 1;
        }
        else if(NPCManager.Instance.Gold < 10){
            less_gold.SetActive(true);
        }
    }

    public void up_dodge()
    {
        if(NPCManager.Instance.Gold >= 10){
            NPCManager.Instance.Gold -= 10;
            Gamemanager.Instance.dodge += 1;
        }
        else if(NPCManager.Instance.Gold < 10){
            less_gold.SetActive(true);
        }
    }
}
