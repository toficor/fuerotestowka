using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GridSettings", menuName = "Grid/GridSettings")]
public class GridSettings : ScriptableObject
{
    public Vector2 startPosition;
    public int columns;
    public int rows;
    public float horizontalSpacing;
    public float verticalSpacing;
}
