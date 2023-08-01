using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class BulletRight : MonoBehaviour

{
    
    public float speed;
    private Rigidbody2D rb;
  
    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        
        rb.velocity = transform.right * speed;
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
                Destroy(gameObject);
            
            
        }

        }


    }
