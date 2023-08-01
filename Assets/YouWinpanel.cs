using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinpanel : MonoBehaviour
{
    public GameObject WinPanel;
    // Start is called before the first frame update
   public void winPanel()
    {
        WinPanel.SetActive(false);
    }
}
