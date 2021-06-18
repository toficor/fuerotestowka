using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BaseAsteroidSetting", menuName = "Asteroids/BaseAsteroidSetting")]
public class AsteroidSettings : ScriptableObject
{
    [SerializeField] private Vector2 speedRange;
    
    public float GetSpeed()
    {
        return Random.Range(speedRange.x, speedRange.y);
    }

    public Vector2 GetRandomDirection()
    {
        return Random.insideUnitCircle.normalized;
    }
}
