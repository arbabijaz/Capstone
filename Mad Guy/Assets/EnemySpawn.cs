using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemy;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        index = Random.Range(0, enemy.Length);
        Instantiate(enemy[index], transform.position, enemy[index].transform.rotation);
    }
}
