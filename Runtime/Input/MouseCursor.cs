using UnityEngine;
using UnityEngine.InputSystem;

namespace SteveJstone
{
    public class MouseCursor : MonoBehaviour
    {
        public LayerMask layerMask;
        private void Update()
        {
            transform.position = Ground.GetMousePosition();
        }
    }
}