using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghost : MonoBehaviour
{
    [HideInInspector]
     public float speed ;
   
    private new Rigidbody2D rigidbody;
    GamePlayUIController gp;

   
    void Start()
    {
        gp = GameObject.FindGameObjectWithTag("Score").GetComponent<GamePlayUIController>();
    }
  
    void Awake()
    {
      
        rigidbody = GetComponent<Rigidbody2D>();
       
    }
  
    
    void FixedUpdate()
    {
      
        rigidbody.velocity = new Vector2( speed,rigidbody.velocity.y);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
           
            Destroy(gameObject);
            
            gp.AddScore();
            


        }
    }
}

