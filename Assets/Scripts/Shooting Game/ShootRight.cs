using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRight : MonoBehaviour
{
   
    public Transform shootingPointright;
   
    public GameObject bulletPrefabRight;
    
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Instantiate(bulletPrefabRight, shootingPointright.position, shootingPointright.rotation);

        }
       

    }
}
