using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LevelButtons : MonoBehaviour
{

    public GameObject[] buttons;
    GamePlayUIController gamePlayUIController;
   
   
    
    private void Awake()
    {
        gamePlayUIController = GetComponent<GamePlayUIController>();
         
    }

    public void Button1()
    {
        if (ScoreCounter.scoreValue <=0)
        {
            SceneManager.LoadScene("GamePlay");

        }
    }
    public void Button2(){
        if(ScoreCounter.scoreValue >= 4){
            SceneManager.LoadScene("GamePlay");
        }
    }
    public void Button3(){
        if(ScoreCounter.scoreValue >= 10){
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button4()
    {
        if (ScoreCounter.scoreValue >= 15)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button5()
    {
        if (ScoreCounter.scoreValue >= 20)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button6()
    {
        if (ScoreCounter.scoreValue >= 25)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button7()
    {
        if (ScoreCounter.scoreValue >= 30)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button8()
    {
        if (ScoreCounter.scoreValue >= 40)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button9()
    {
        if (ScoreCounter.scoreValue >= 50)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button10()
    {
        if (ScoreCounter.scoreValue == 55)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button11()
    {
        if (ScoreCounter.scoreValue >= 60)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button12()
    {
        if (ScoreCounter.scoreValue >= 65)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button13()
    {
        if (ScoreCounter.scoreValue >= 70)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }

    public void Button14()
    {
        if (ScoreCounter.scoreValue >= 75)
        {
            SceneManager.LoadScene("GamePlay");
        }
    }
    // Start is called before the first frame update
    /* void Start()
     {
         foreach(var button in buttons)
         {
             button.SetActive(false);
         }
     }
    */

    // Update is called once per frame
    /*  public void Button2()
      {
          if ( gamePlayUIController.score.text == "5")
          {


              buttons[0].SetActive(true);
              SceneManager.LoadScene("GameOver");
          }
          else
          {

              SceneManager.LoadScene("GameOver");
              youWinpanel.winPanel();
          }
      }*/

}
