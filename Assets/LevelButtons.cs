using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour
{

    public GameObject[] buttons;
    GamePlayUIController gamePlayUIController;
    YouWinpanel youWinpanel;
   
    
    private void Awake()
    {
        gamePlayUIController = GetComponent<GamePlayUIController>();
          youWinpanel = GetComponent<YouWinpanel>();
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
