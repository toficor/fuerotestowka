using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform targetTransofrm;
    [SerializeField] private CameraSettings cameraSettings;

    private readonly Vector3 basic2DOffset = new Vector3(0, 0, -10);

    private void Update()
    {
        Vector2 desiredPostion = (Vector2)targetTransofrm.position + cameraSettings.Offset;
        Vector2 interpolatedPosition = Vector2.Lerp(transform.position, desiredPostion, cameraSettings.SmoothSpeed * Time.deltaTime);
        transform.position = (Vector3)interpolatedPosition + basic2DOffset;
    }


}
