using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScoreUI 
{
    private readonly string stringFormat = "Player Score: {0}";
    private readonly TextMeshProUGUI textMeshProUGUI;


    public PlayerScoreUI(TextMeshProUGUI textMeshProUGUI)
    {
        this.textMeshProUGUI = textMeshProUGUI;
    }

    public void HandleDisplayingPlayersScore( int value)
    {
        textMeshProUGUI.text = string.Format(stringFormat, value);
    }

}
