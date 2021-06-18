using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AmmunitionSettings", menuName = "Weapon/AmmunitionTemplate")]
public class AmmunitionSettings : ScriptableObject
{
    [SerializeField] private float lifeTime;
    [SerializeField] private float speed;

    public float LifeTime { get { return lifeTime; } }
    public float Speed { get { return speed; } }
}
