using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScoreYouGot;

    GamePlayUIController gamePlayUIController;

    void Start()
    {

        gamePlayUIController = gameObject.GetComponent<GamePlayUIController>();

       finalScoreYouGot.text = gamePlayUIController.score.ToString()
;        Debug.Log("FinalScore");
    }

   
}
   
