using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }
    /*private void OnEnable()
    {
        Monster.OnScoreAdd += scoreValues;
    }*/
    void Update()
    {
        //Debug.Log(scoreValue);
        score.text = scoreValue.ToString();
    }
}
