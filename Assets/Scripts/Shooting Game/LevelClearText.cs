using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LevelClearText : MonoBehaviour
{
    internal Text levelClearText;
    GamePlayUIController gamePlayUIController;
    

    private void Start()
    {
        gamePlayUIController =GetComponent<GamePlayUIController>();
        
        levelClearText.text = "Level Cleared";
    }





}
