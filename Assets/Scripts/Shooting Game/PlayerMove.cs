using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    private Animator anim;
    private string animation = "Walk";
    private float movementX;
    private SpriteRenderer sr;
    private Rigidbody2D myBody;
    private bool isGrounded;
    YouWinpanel youwin;
    //private int life= 3;
  //  public Rigidbody2D playerPrefab;
    //public Vector2 prefabPos;
    


    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
       // playerPrefab = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();   
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        playerMove();
        Player();

    }

    private void FixedUpdate()
    {
        PlayerJump();   
    }

    void playerMove()
    {
        movementX   = Input.GetAxis("Horizontal");
           
        transform.position += new Vector3(movementX, 0f, 0f)*10f * Time.deltaTime;

    }
    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, 11f), ForceMode2D.Impulse);
           // Debug.Log("Jump Pressed");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {

            Destroy(gameObject);
            
            SceneManager.LoadScene(2);
            youwin.winPanel();



            /*  if (life > 0)
              {

                 // Destroy(gameObject);
                  //Invoke("PlayerInstantiate",2f);
                //  Invoke("PlayerInstantiate", 1f);

                 // life--;
                 // Destroy(gameObject);
              }
              else {
                  Destroy(gameObject);
              }*/

        }
    }

  /*  void PlayerInstantiate()
    {
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
        Debug.Log("Palyer Initiated");
    }
  */
    void Player()
    {
        if (movementX > 0)
        {
            anim.SetBool(animation, true);
            sr.flipX=false;
                    }
        else if (movementX < 0)
        {
            anim.SetBool(animation, true);
            sr.flipX = true ;
        }
        else
        {
            anim.SetBool(animation, false);
        }
    }

     
  
}
