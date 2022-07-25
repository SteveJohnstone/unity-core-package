using UnityEngine;

public static class CameraExtensions
{
    public static Vector3[] GetFrustrumCornerWorldPositions(this Camera camera)
    {
        Vector3[] frustumCorners = new Vector3[4];
        Vector3[] frustumCornersWorldPos = new Vector3[4];
        camera.CalculateFrustumCorners(new Rect(0, 0, 1, 1), camera.farClipPlane, Camera.MonoOrStereoscopicEye.Mono, frustumCorners);

        for (int i = 0; i < 4; i++)
        {
            var worldSpaceCorner = camera.transform.TransformVector(frustumCorners[i]);
            frustumCornersWorldPos[i] = worldSpaceCorner;
        }
        return frustumCornersWorldPos;
    }
}

