using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollowLevel : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;

    private void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(targetToFollow.position.x,-634.64f,49.99f),0
            
            );
    }
    //private Vector3 temppos;





    /* void Start()
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
     }*/

} 

