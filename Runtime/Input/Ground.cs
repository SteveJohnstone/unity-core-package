using UnityEngine;
using UnityEngine.InputSystem;

namespace SteveJstone
{
    public static class Ground
    {
        public static Vector3 GetMousePosition()
        {
            var screenRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            var collisions = Physics.RaycastAll(screenRay, 1000f, layerMask: LayerMask.GetMask("Ground"));

            if (collisions.Length > 0)
            {
                return collisions[0].point;
            }

            throw new System.Exception("Unable to find ground position");
        }
    }
}