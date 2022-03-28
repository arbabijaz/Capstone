using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("fire", 1,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void fire()
    {
        GameObject bulletfire;
        bulletfire = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(bulletfire, 2f);
    }
}
