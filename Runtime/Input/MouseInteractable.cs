using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace SteveJstone
{
    public class MouseInteractable : MonoBehaviour
    {
        public event UnityAction OnMouseEnter = delegate { };
        public event UnityAction OnMouseExit = delegate { };
        public event UnityAction OnMouseClick = delegate { };

        private bool _mouseOver;
        private Collider _collider;

        public void OnEnable()
        {
            _collider = GetComponent<Collider>();
        }
        public void Update()
        {
            var mouseRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (_collider.bounds.IntersectRay(mouseRay))
            {
                if (!_mouseOver)
                {
                    Debug.Log("Mouse entered collider");
                    _mouseOver = true;
                    OnMouseEnter?.Invoke();
                }

                if (Mouse.current.leftButton.wasReleasedThisFrame)
                {
                    Debug.Log("Mouse clicked on collider");
                    OnMouseClick?.Invoke();

                }
            } 
            else if (!_collider.bounds.IntersectRay(mouseRay) && _mouseOver)
            {
                Debug.Log("Mouse exited collider");
                _mouseOver = false;

                OnMouseExit?.Invoke();
            }
        }
    }
}
