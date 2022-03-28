using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed =  20;
    public float damage = 100;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public float ReturnDamage()
    {
        return damage;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Debug.Log("Enemy Hit");
            collision.gameObject.GetComponent<enemycontroller>().getDamage(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Pickup"))
        {
            Debug.Log("Pickup Hit");
            collision.gameObject.GetComponent<PickupManager>().GetDamage(damage);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
            collision.gameObject.GetComponent<PlayerController>().getDamage(damage);
            Destroy(gameObject);
        }
    }
}
