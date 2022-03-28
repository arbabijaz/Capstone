using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handGun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Mouse Down");
            fire();
        }
        
    }
    void fire()
    {
        GameObject bulletfire;
        bulletfire = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(bulletfire, 2f);
    }
}
