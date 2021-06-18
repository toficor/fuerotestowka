using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GridManager 
{
    public static List<Vector2> GeneraterGird(Vector2 startPosition ,int columns, int rows, float xSpacing, float ySpacing)
    {
        List<Vector2> grid = new List<Vector2>();

        for(int i = 0; i < columns * rows; i++)
        {
            Vector2 gridElement = new Vector2(startPosition.x + (xSpacing * (i % columns)), startPosition.y + (ySpacing * (i / columns)));
            grid.Add(gridElement);
        }

        return grid;

    }
}
