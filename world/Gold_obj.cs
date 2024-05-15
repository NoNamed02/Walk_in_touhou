using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold_obj : MonoBehaviour
{
    public GameObject Text;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) //
        {
            NPCManager.Instance.Gold += 1;
            Destroy(gameObject);
        }
        Text.SetActive(true);
    }
}
