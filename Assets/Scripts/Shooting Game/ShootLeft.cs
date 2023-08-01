using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLeft : MonoBehaviour
{

   

    public Transform shootingPointleft;

    public GameObject bulletPrefableft;
  
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {

          
            Instantiate(bulletPrefableft, shootingPointleft.position, shootingPointleft.rotation);

        }


    }

}
