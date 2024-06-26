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
        float X = Random.Range(-21, 22);
        float Y = Random.Range(-13, 17);
        gameObject.transform.position = new Vector3(X, Y, -1f);
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
            //col.enabled = false;
            Sound.Play();
            NPCManager.Instance.Gold += 1;
            //Destroy(gameObject);
            random_move();
        }
        Text.SetActive(true);
    }
    void random_move(){
        float X = Random.Range(-21, 22);
        float Y = Random.Range(-13, 17);
        gameObject.transform.position = new Vector3(X, Y, -1f);
    }
}
