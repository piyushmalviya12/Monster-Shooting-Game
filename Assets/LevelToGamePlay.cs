using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LevelToGamePlay : MonoBehaviour
{
   

     
    public void GoToGamePlay()
    {
        SceneManager.LoadScene("Levels");
    }

    public void GoToGamePlayButton1()
    {
        SceneManager.LoadScene("GamePlay");
        ScoreCounter.scoreValue = 0;
    }

}

   

