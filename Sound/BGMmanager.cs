using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    private static BGMmanager instance;
    public CameraSwitch C;

    public static BGMmanager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject singletonObject = new GameObject();
                instance = singletonObject.AddComponent<BGMmanager>();
                singletonObject.name = typeof(BGMmanager).ToString() + " (Singleton)";
                DontDestroyOnLoad(singletonObject);
            }
            return instance;
        }
    }
    
    
    public AudioSource Sound;
    public AudioClip Main;
    public string sound_name;

    public void Playsound(string n){
        sound_name = n;
        switch(sound_name){
            case "Main":
                Sound.clip = Main;
                break;
        }
        Sound.Play();
    }

    void Update(){
        if(!Sound.isPlaying && C.isCameraActive == 1){
            Sound.Stop();
            Playsound("Main");
        }
    }
}
