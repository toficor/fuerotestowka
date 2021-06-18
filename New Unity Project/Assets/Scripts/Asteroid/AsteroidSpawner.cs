using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Rendering;
using Unity.Collections;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GridSettings gridSettings;
    [SerializeField] private Mesh asterodiMesh;
    [SerializeField] private Material asterodiMaterial;
    [SerializeField] private AsteroidSettings asteroidSettings;


    private List<Vector2> grid;

    private void Awake()
    {
        grid = GridManager.GeneraterGird(gridSettings.startPosition, gridSettings.columns, gridSettings.rows, gridSettings.horizontalSpacing, gridSettings.verticalSpacing);
        SpawnAsteroids();
    }


    private void Start()
    {
        
    }

    private void SpawnAsteroids()
    {
        EntityManager entityManager = World.Active.EntityManager;

        EntityArchetype entityArchetype = entityManager.CreateArchetype(
            typeof(Translation),
            typeof(RenderMesh),
            typeof(LocalToWorld),
            typeof(RenderBounds),
            typeof(AsteroidMoverComponent)
            );

        NativeArray<Entity> asteroids = new NativeArray<Entity>(gridSettings.columns * gridSettings.rows, Allocator.Temp);

        entityManager.CreateEntity(entityArchetype, asteroids);

        for(int i = 0; i < asteroids.Length; i++)
        {
            Entity entity = asteroids[i];
            entityManager.SetSharedComponentData(entity, new RenderMesh
            {
                mesh = asterodiMesh,
                material = asterodiMaterial,
            }) ;

            entityManager.SetComponentData(entity, new AsteroidMoverComponent { 
                speed = asteroidSettings.GetSpeed(), 
                direction = asteroidSettings.GetRandomDirection() 
            });

            entityManager.SetComponentData(entity, new Translation {Value = new Unity.Mathematics.float3(grid[i].x, grid[i].y, 0) });

        }

        asteroids.Dispose();

    }

}
