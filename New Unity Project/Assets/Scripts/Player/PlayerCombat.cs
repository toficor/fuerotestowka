using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat
{
    private readonly PlayerSettings playerSettings;

    private float shootingTimer = 0f;
    public PlayerCombat(PlayerSettings playerSettings)
    {
        this.playerSettings = playerSettings;
    }

    public void HandleShot(AmmunitionBase ammunition, Vector3 postion, Quaternion rotation)
    {
        shootingTimer += Time.deltaTime;

        if (shootingTimer >= playerSettings.ShootInterval)
        {
            GameObject.Instantiate(ammunition.gameObject, postion, rotation);
            shootingTimer = 0f;
        }
    }
}
