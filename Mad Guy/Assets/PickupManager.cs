using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    public GameObject pickUp;
    public float currentHealth;
    public float totleHealth = 200;
    
    
    public PickupManager()
    {
        currentHealth = totleHealth;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetDamage(float damage)
    {
        if (currentHealth>0)
        {
            currentHealth -= damage;
            healthchecker();
            Debug.Log(currentHealth);
        }
        else
        {
            destroyPickup();
        }
        
    }
    void destroyPickup()
    {
        Instantiate(pickUp, transform.position, pickUp.transform.rotation);
        Destroy(gameObject);
    }
    void healthchecker()
    {
        if (currentHealth > totleHealth)
        {
            currentHealth = totleHealth;
            
        }
        
    }
    
}