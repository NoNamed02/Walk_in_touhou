using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scencemanager : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake(){

        int setWidth = 1500;
        int setHeight = 3088;
        Screen.orientation = ScreenOrientation.Portrait;
        int deviceW = Screen.width;
        int deviceH = Screen.height;

        Screen.SetResolution(setWidth, (int)((float)deviceH / deviceW * setWidth), true);

        if((float) setWidth / setHeight < (float) deviceW / deviceH){
            float newW = ((float)setWidth / setHeight) / ((float)deviceW / deviceH);
            Camera.main.rect = new Rect((1f - newW) / 2f, 0f, newW, 1f);
        }
        else{
            float newH = ((float)setWidth / setHeight) / ((float)deviceW / deviceH);
            Camera.main.rect = new Rect(0f, (1f - newH) / 2f, 1f, newH);
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
