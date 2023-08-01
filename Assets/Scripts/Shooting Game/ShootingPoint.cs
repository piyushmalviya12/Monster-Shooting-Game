using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPoint : MonoBehaviour
{
    public Transform shootingpoint;
    public GameObject bulletPrefab;
    private Rigidbody2D rb;
   

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>() as Rigidbody2D;

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab);
            Debug.Log("Bullet Initiated");
        }
    }





}

  
  

