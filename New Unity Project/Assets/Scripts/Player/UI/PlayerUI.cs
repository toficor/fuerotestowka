using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerScoreTextMesh;
    [SerializeField] private GameManagerData gameManagerData;

    private PlayerScoreUI playerScoreUI;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Initialization();
    }

    private void Initialization()
    {
        playerScoreUI = new PlayerScoreUI(playerScoreTextMesh);
    }

    // Update is called once per frame
    void Update()
    {
        playerScoreUI.HandleDisplayingPlayersScore(gameManagerData.playerScore);
    }
}
