using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;   // reference to this UI Manager

    public Text gameOverText;

    private void Awake()
    {
        Instance = this;
        gameOverText.text = "";
    }

    public void SetGameOverText()
    {
        gameOverText.text = "FINISHED GAME";
    }
}
