using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public Slider HpBarSlider;
    public void CheckHp()
    {
        if (HpBarSlider != null)
            HpBarSlider.value = Gamemanager.Instance.player_HP / Gamemanager.Instance.maxHP;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckHp();
    }
}
