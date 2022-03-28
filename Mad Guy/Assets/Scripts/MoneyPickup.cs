using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPickup : pickup
{
    
    public MoneyPickup()
    {
        points = 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        PickUpDestroyTimer(gameObject);
    }
    public override void use(GameObject player)
    {
        Debug.Log("Overide Function Call");
        player.GetComponent<PlayerController>().setScore(points);
        
    }
}
