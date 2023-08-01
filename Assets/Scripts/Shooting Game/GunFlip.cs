using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFlip : MonoBehaviour
{
    void Update()
    {
       Flip();
      
    }
    void Flip()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 180, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 180, 0);
        }


    }
}
