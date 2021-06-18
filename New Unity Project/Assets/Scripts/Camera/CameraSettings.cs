using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CameraSettings", menuName = "Camera/CameraSettings")]
public class CameraSettings : ScriptableObject
{
    [SerializeField] private float smoothSpeed = 1f;
    [SerializeField] private Vector2 offset = Vector2.zero;

    public float SmoothSpeed { get { return smoothSpeed; } }
    public Vector2 Offset { get { return offset; } }
}
