using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class AsteroidMoverSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Translation translation, ref AsteroidMoverComponent asteroidMoverComponent) =>
        {
            translation.Value.x += asteroidMoverComponent.direction.x * asteroidMoverComponent.speed;
            translation.Value.y += asteroidMoverComponent.direction.y * asteroidMoverComponent.speed;

        });
    }
}
