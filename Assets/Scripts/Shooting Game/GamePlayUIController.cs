using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUIController : MonoBehaviour
{
    public  Text score;

    [SerializeField]
    public int playerscore;

    LevelButtons levelButtons;

   //public int ss;
    

    
    public void Home()
    {
        SceneManager.LoadScene(0);
    }

  

    public  void AddScore()
    {
        playerscore = playerscore + 1;
        
        score.text = " ";
        score.text = playerscore.ToString();
        if (playerscore  == 5)
        {
            Debug.Log(score.text);
            SceneManager.LoadScene("GameOver");
           
        }


    }

    public void NextLevel()
    {
           
       
            SceneManager.LoadScene("Levels");
          levelButtons.buttons[1].SetActive(true);


    }


   
    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(1);
    }
}
