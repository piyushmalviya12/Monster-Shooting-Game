using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMove : MonoBehaviour
{

    private float movementX;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    private void Awake()
    {
       
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movementX = Input.GetAxis("Mouse ScrollWheel");

        transform.position += new Vector3(movementX, 0f, 0f) * 2000f * Time.deltaTime;

        if (movementX > 0)
        {
           
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
          
            sr.flipX = true;
        }


    }
}
