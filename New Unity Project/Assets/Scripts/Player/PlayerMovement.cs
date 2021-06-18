using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    private readonly IShipInput shipInput;
    private readonly Transform playerTransform;
    private readonly PlayerSettings playerSettings;

    public PlayerMovement(IShipInput shipInput, Transform playerTransform, PlayerSettings playerSettings)
    {
        this.shipInput = shipInput;
        this.playerSettings = playerSettings;
        this.playerTransform = playerTransform;
    }
    

    public void HandleMovement()
    {
        playerTransform.position += playerTransform.up * shipInput.Thrust * Time.deltaTime * playerSettings.MoveSpeed;
        playerTransform.Rotate(-Vector3.forward * shipInput.Rotation * Time.deltaTime * playerSettings.TurnSpeed);
    }
}
