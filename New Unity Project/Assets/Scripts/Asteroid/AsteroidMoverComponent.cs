using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public struct AsteroidMoverComponent : IComponentData
{
    public float speed;
    public Vector2 direction;
}
