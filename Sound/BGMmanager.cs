using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    //private static BGMmanager instance;
    public static BGMmanager Instance;
    public CameraSwitch C;
    
    public AudioSource Sound;
    public AudioClip Main;
    public AudioClip Hakurei;
    public string sound_name;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            // AudioSource가 null일 경우 추가
            if (Sound == null)
            {
                Sound = gameObject.AddComponent<AudioSource>();
            }
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void Playsound(string n){
        sound_name = n;
        switch(sound_name){
            case "Main":{
                Sound.clip = Main;
                break;}
            case "Hakurei":{
                Sound.clip = Hakurei;
                break;}
        }
        Sound.Play();
    }
    /*
    void Update(){
        if(!Sound.isPlaying && C.isCameraActive == 1){
            Sound.Stop();
            Playsound("Main");
        }
    }
    */
}
