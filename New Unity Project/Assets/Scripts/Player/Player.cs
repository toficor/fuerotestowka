using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDestructable
{
    [SerializeField] private PlayerSettings playerSettings;
    [SerializeField] private Transform shootingStartPosition;
    [SerializeField] private AmmunitionBase currentAmmunition;

    private IShipInput shipInput;
    private PlayerMovement playerMovement;
    private PlayerCombat playerCombat;

    private void Awake()
    {
        shipInput = new PlayerInput();
        playerMovement = new PlayerMovement(shipInput, transform, playerSettings);
        playerCombat = new PlayerCombat(playerSettings);
    }

    private void Update()
    {
        shipInput.ReadInput();
        playerMovement.HandleMovement();
        playerCombat.HandleShot(currentAmmunition, shootingStartPosition.position, shootingStartPosition.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Obstacle"))
        {
            HandleDestroy();
        }
    }   


    public void HandleDestroy()
    {
        //for now only destory

        Destroy(gameObject);
    }
}
