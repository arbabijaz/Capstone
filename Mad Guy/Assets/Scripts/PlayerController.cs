using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayerController : MonoBehaviour
{
    Animator animator;
    public int speed = 10;
    public float jumpForce;
    float horizontal;
    Rigidbody rb;
    public float totalhealth=100;
    public float currentHealth;
    public bool isAlive = true;
    public float score = 0;
    public TextMeshProUGUI scoreTxt;
    public GameObject levelComplete;
    
    
    void Start()
    {
        currentHealth = totalhealth;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.SetText("Score : " + score);
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed *horizontal* Time.deltaTime);
        animator.SetFloat("Speed", horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("isJump");
        }

        
       
        


        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("crouch", true);
        }
        else
        {
            animator.SetBool("crouch", false);
        }

    }
    
    public void setHealth(float heal)
    {
        if (healthchecker())
        {
            currentHealth += heal;
            healthchecker();
        }
        else
        {
            die();
        }
        
    }
    public void setScore(float points)
    {
        score += points;
    }
    bool healthchecker()
    {
        if (currentHealth > 0 && currentHealth <= 100)
        {
            return true;
        }
        else if (currentHealth > totalhealth)
        {
            currentHealth = totalhealth;
            return true;
        }
        return false;
    }
    public void getDamage(float damage)
    {
        Debug.Log("Player Collided with bullet");
        if (healthchecker())
        {
            currentHealth -= damage;
        }
        else
        {
            die();
        }

    }
    void die()
    {
        animator.SetBool("IsDie", true);
        isAlive = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            Debug.Log("Player Collided with pickup");
            collision.gameObject.GetComponent<pickup>().use(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("FinishLine"))
        {
            collision.gameObject.SetActive(true);
        }
    }
}
