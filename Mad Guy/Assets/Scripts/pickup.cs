using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    protected float points;
    protected PlayerController player;

    public virtual void use(GameObject player)
    {
        Debug.Log("Base PickUp Class");
    }
    
   
    public void PickUpDestroyTimer(GameObject item)
    {
        Destroy(item,5f);
    }
}
