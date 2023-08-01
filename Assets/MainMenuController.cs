using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainMenuController : MonoBehaviour
{
    public void GoToGameLevels()
    {

        int selectedCharacter = int.Parse(EventSystem.current.currentSelectedGameObject.name);
        GameManager.instance.charIndex = selectedCharacter;
        SceneManager.LoadScene("Levels");
    }

   public void PlayGame()
    {

        SceneManager.LoadScene("GamePlay");
    } 
}
