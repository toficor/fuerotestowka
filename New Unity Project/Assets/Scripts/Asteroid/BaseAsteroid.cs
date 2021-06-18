using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAsteroid : MonoBehaviour, IDestructable
{
    [SerializeField] private AsteroidSettings asteroidSettings;
    [SerializeField] private GameManagerData gameManagerData;

    public void HandleDestroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacle") == false && collision.CompareTag("Player") == false)
        {
            gameManagerData.playerScore++;
        }

        Destroy(gameObject);
    }
}
