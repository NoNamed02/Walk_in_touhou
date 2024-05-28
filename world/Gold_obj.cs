using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold_obj : MonoBehaviour
{
    public GameObject Text;
    public AudioSource Sound;
    public Collider2D col;
    void Start()
    {
        Sound = GetComponent<AudioSource>();
        col = GetComponent<Collider2D>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) //
        {
            col.enabled = false;
            Sound.Play();
            NPCManager.Instance.Gold += 1;
            //Destroy(gameObject);
        }
        Text.SetActive(true);
    }
}
