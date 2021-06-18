using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManagerData", menuName = "Managers/GameManagerData")]
public class GameManagerData : ScriptableObject
{
    public int playerScore;
    [SerializeField] public bool isGameRunning;
    [SerializeField] public bool isPlayerAlive;
    [SerializeField] private int playerBestScore;
}
