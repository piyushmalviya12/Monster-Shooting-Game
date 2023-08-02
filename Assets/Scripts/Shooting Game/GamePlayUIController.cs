using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUIController : MonoBehaviour
{
   // public  Text score;

    
   //public  int playerscore;

    LevelButtons levelButtons;

   //public int ss;
    

    
    

  

    public  void AddScore()
    {
        ScoreCounter.scoreValue = ScoreCounter.scoreValue + 1;

        //score.text = " ";
        //score.text = playerscore.ToString();
       
        /* if (ScoreCounter.scoreValue == 5)
         {
             Debug.Log(score.text);

             SceneManager.LoadScene("GameWin");
         }*/
        if (ScoreCounter.scoreValue == 5)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 10)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 15)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 20)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 25)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 30)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 35)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 40)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 45)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 50)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 55)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 60)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 65)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 70)
        {
            SceneManager.LoadScene("GameWin");
        }
        else if (ScoreCounter.scoreValue == 75)
        {
            SceneManager.LoadScene("GameWin");
        }


    }

   


   
    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("GamePlay");
    }
}
