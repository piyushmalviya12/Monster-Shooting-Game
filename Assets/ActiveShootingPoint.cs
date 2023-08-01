using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveShootingPoint : MonoBehaviour
{
    public GameObject shootingPointRight;
    public GameObject shootingPointLeft;

    private void Start()
    {
        shootingPointRight.SetActive(true);

        shootingPointLeft.SetActive(false);
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            shootingPointLeft.SetActive(true);
            shootingPointRight.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            shootingPointRight.SetActive(true);
            shootingPointLeft.SetActive(false);
        }

    }
}
