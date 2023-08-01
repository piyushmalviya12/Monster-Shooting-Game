using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollowLevel : MonoBehaviour
{
    private Transform ScrollPosition;
    private Vector3 temppos;

    [SerializeField]
    private float maxX, minX;


    void Start()
    {
        ScrollPosition = GameObject.FindWithTag("ScrollLimit").transform;
    }


    void LateUpdate()
    {
        
            temppos = transform.position; // camera's current position
            temppos.x = ScrollPosition.position.x;
        
        if (temppos.x > maxX)
            temppos.x = maxX;
        if (temppos.x < minX)
            temppos.x = minX;
        transform.position = temppos;
    }
} 

