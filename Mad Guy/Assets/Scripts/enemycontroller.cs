using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{
    public float health = 100;
    public GameObject killPoints;
    Animator animator;
    Vector3 offset = new Vector3(0, 1, 0);

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
        }
        else
        {
            die();
        }
    }
    void die()
    {
        animator.SetBool("IsDie", true);
        //transform.position += new Vector3(0, -1, 0);
        Destroy(gameObject,3f);
        KillPoints();

    }
    void KillPoints()
    {
        Instantiate(killPoints, transform.position+offset, killPoints.transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
