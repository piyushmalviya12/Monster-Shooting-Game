using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   private Transform player;
   private Vector3 temppos;

    [SerializeField]
    private float maxX, minX;

    
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

   
    void LateUpdate()
    {
        if (player != null)
        {
            temppos = transform.position; // camera's current position
            temppos.x = player.position.x; 
        }
        if(temppos.x > maxX) 
            temppos.x = maxX;
        if (temppos.x < minX)
            temppos.x = minX;
        transform.position = temppos;
    }
} 
