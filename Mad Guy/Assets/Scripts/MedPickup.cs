using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedPickup : pickup
{
    
    public float healPow = 30;
    // Start is called before the first frame update
    void Start()
    {
        PickUpDestroyTimer(gameObject);
    }

    public override void use(GameObject player)
    {
        
        Debug.Log("Overide Function Call");
        player.GetComponent<PlayerController>().setHealth(healPow);
        
    }
}
