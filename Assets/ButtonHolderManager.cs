using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHolderManager : MonoBehaviour
{
    private float movementX;
    private SpriteRenderer sr;


    private void Awake()
    {

        sr = GetComponent<SpriteRenderer>();
    }

    void ButtonHolderMove()
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
    void Update()
    {
        ButtonHolderMove();
    }
}
