using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmunitionBase : MonoBehaviour, IDestructable
{
    [SerializeField] private AmmunitionSettings ammunitionSettings;

    private float lifeTimeTimer;

    private void OnEnable()
    {
        lifeTimeTimer = 0f;
    }

    protected virtual void Update()
    {
        HandleMovement();
        HandleLifeTime();
    }

    public void HandleDestroy()
    {
        //future enque from pool

        Destroy(gameObject);
    }

    protected virtual void HandleMovement()
    {
        transform.position += transform.up * ammunitionSettings.Speed * Time.deltaTime;
    }

    protected virtual void HandleLifeTime()
    {
        lifeTimeTimer += Time.deltaTime;
        if (lifeTimeTimer >= ammunitionSettings.LifeTime)
        {
            HandleDestroy();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            HandleDestroy();
        }
    }
}
