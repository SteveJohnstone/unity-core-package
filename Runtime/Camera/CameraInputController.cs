using UnityEngine;
using UnityEngine.InputSystem;
using SteveJstone;

namespace SteveJstone
{
    public class CameraInputController : MonoBehaviour
    {
        [SerializeField] private CameraInputReader _inputReader = default;
        private CameraController _camera;

        void Start()
        {
            _camera = GetComponent<CameraController>();
        }

        void OnEnable()
        {
            _inputReader.CameraZoomEvent += OnZoom;
            _inputReader.CameraMoveEvent += OnMove;
            _inputReader.CameraRotateLeftEvent += OnRotateLeft;
            _inputReader.CameraRotateRightEvent += OnRotateRight;
        }

        public void Update()
        {
            if (_inputReader.MiddleMouseDown)
            {

                _camera.MouseRotate(Mouse.current.delta.ReadValue() * Time.deltaTime);
            }
        }

        private void OnRotateRight()
        {
            _camera.RotateRight();
        }

        private void OnRotateLeft()
        {
            _camera.RotateLeft();
        }

        private void OnMove(Vector2 value)
        {
            _camera.Move(value);
        }

        private void OnZoom(float amount)
        {
            _camera.Zoom(amount);
        }
    }
}