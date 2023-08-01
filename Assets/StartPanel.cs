using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public GameObject panel;
    LevelButtons buttons;
    public void GameStart()
    {
        panel.SetActive(false);

        foreach (var button in buttons.buttons)
        {
            button.SetActive(false);
        }
    }
}
