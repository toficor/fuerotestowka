using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Player/PlayerSettings")]
public class PlayerSettings : ScriptableObject
{
    [SerializeField] private float turnSpeed = 10f;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float shootInterval = 0.3f;

    public float TurnSpeed { get { return turnSpeed; } }
    public float MoveSpeed { get { return moveSpeed; } }
    public float ShootInterval { get { return shootInterval; } }

}
