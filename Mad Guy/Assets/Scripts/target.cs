using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    Vector3 pos;
    Vector3 senstivity = new Vector3(0, 10, 10);


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = Input.mousePosition;
        pos.z = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos)+senstivity;
    }

}
