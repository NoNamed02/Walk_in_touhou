using UnityEngine;
using System.Collections;

public class monster_spwaner : MonoBehaviour {
    public Transform[] points;
    public GameObject monsterPrefab;

    public float createTime;
    public int maxMonster = 10;
    public int monsterCount;

    void Start () {
        points = GameObject.Find("SpawnPoint").GetComponentsInChildren<Transform>();
        StartCoroutine(CreateMonster());
    }
    void Update(){
        monsterCount = (int)GameObject.FindGameObjectsWithTag("enemy").Length;
    }
    IEnumerator CreateMonster()
    {
            if(monsterCount < maxMonster)
            {
                yield return new WaitForSeconds(createTime);
                int idx = Random.Range(1, points.Length);
                Instantiate(monsterPrefab, points[idx].position, points[idx].rotation);
                StartCoroutine(CreateMonster());
            }else
            {
                Debug.Log("몬스터 안나옴");
                //yield return null;
                yield return new WaitForSeconds(createTime);
                StartCoroutine(CreateMonster());
            }
    }
}

