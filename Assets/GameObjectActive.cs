using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameObjectActive : MonoBehaviour
{
    public GameObject Levelpanel;
    public bool state;

    


    private void Start()
    {
       
       Levelpanel.SetActive(state);
    }

    
}
