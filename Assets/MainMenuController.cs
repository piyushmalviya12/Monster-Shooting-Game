using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainMenuController : MonoBehaviour
{

    GamePlayUIController gamePlayUIController;
    public void GoToGameLevels()
    {

        int selectedCharacter = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.charIndex = selectedCharacter;
        SceneManager.LoadScene("Levels");
    }


    public void RestartGameWin()
    {
        SceneManager.LoadScene("GamePlay");
        ScoreCounter.scoreValue = 0;
    }
    public void Home()
    {

        SceneManager.LoadScene("Main Menu");
        ScoreCounter.scoreValue =0;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    } 
}
