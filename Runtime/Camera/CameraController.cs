using DG.Tweening;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace SteveJstone
{
    [ExecuteAlways]
    public class CameraController : MonoBehaviour
    {
        [Title("References")]
        [SerializeField] private Camera _camera;
        [SerializeField] private Transform _boom;

        [Title("Zoom")]
        [Range(10, 1000)]
        [SerializeField] private float _zoom = 100;
        [SerializeField] private float _minZoom = 10;
        [SerializeField] private float _maxZoom = 1000;
        [SerializeField] private float _zoomLag = .1f;
        [SerializeField] private float _zoomStep = 15f;
        [SerializeField] private float _zoomScale = .5f;

        [Title("Rotation", horizontalLine: false)]
        [SerializeField] private float _rotationSpeed = 1f;
        [SerializeField] private float _mouseRotateSpeed = 100f;
        [SerializeField] private float _rotation = 0;

        [Title("Elevation", horizontalLine: false)]
        [Range(10, 80)]
        [SerializeField] private float _elevation = 45;

        [Title("Movement", horizontalLine: false)]
        [SerializeField] private float _moveSpeed = 10;

        public enum LimitType
        {
            Coordinates, Distance, None
        }

        [Title("Limits")]
        [SerializeField]
        private LimitType _boundsLimitType = LimitType.Coordinates;

        [ShowIf("_boundsLimitType", LimitType.Coordinates)]
        [SerializeField] private Vector3 _boundsCoordinates;

        [ShowIf("_boundsLimitType", LimitType.Distance)]
        [SerializeField] private float _boundsDistance;

        private float _targetZoom = 100;
        private Vector3 _moveDirection;

        private void Start()
        {
            _targetZoom = _zoom;
        }

        private void Update()
        {
            UpdateElevation();
            UpdateZoom();
            UpdateRotation();
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            var newPosition = transform.position + _moveDirection * Time.deltaTime * _moveSpeed;

            if (_boundsLimitType == LimitType.Coordinates)
            {
                newPosition.x = Mathf.Clamp(newPosition.x, -_boundsCoordinates.x, _boundsCoordinates.x);
                newPosition.y = Mathf.Clamp(newPosition.y, -_boundsCoordinates.y, _boundsCoordinates.y);
                newPosition.z = Mathf.Clamp(newPosition.z, -_boundsCoordinates.z, _boundsCoordinates.z);
            }
            else if (_boundsLimitType == LimitType.Distance)
            {
                if (newPosition.sqrMagnitude > _boundsDistance * _boundsDistance)
                {
                    newPosition = newPosition.normalized * _boundsDistance;
                }
            }

            transform.position = newPosition;
        }

        public void Move(Vector2 value)
        {
            _moveDirection = transform.rotation * new Vector3(value.x, 0, value.y);
        }

        public void MouseRotate(Vector2 delta)
        {
            _rotation += delta.x * _mouseRotateSpeed;
            _elevation -= delta.y * _mouseRotateSpeed;
        }

        [Title("Debug Controls")]
        [Button]
        public void ZoomOut()
        {
            DOTween.To(() => _targetZoom, x => _targetZoom = x, _targetZoom + _zoomStep, 1f);
        }

        [Button]
        public void ZoomIn()
        {
            DOTween.To(() => _targetZoom, x => _targetZoom = x, _targetZoom - _zoomStep, 1f);
        }

        public void Zoom(float amount)
        {
            _targetZoom -= (amount * _zoomScale * Time.deltaTime);
            _targetZoom = Mathf.Clamp(_targetZoom, _minZoom, _maxZoom);
        }


        [Button]
        public void RotateLeft()
        {
            DOTween.To(() => _rotation, x => _rotation = x, _rotation + 90, _rotationSpeed);
        }

        [Button]
        public void RotateRight()
        {
            DOTween.To(() => _rotation, x => _rotation = x, _rotation - 90, _rotationSpeed);
        }


        private void UpdateZoom()
        {
            _zoom = Mathf.Lerp(_zoom, _targetZoom, _zoomLag);
            if (Mathf.Abs(_zoom - _targetZoom) < 0.01f)
            {
                _zoom = _targetZoom;
            }
            var position = _camera.transform.localPosition;
            position.z = -_zoom;
            _camera.transform.localPosition = position;
        }

        private void UpdateElevation()
        {
            var rotation = _boom.transform.localEulerAngles;
            _elevation = Mathf.Clamp(_elevation, 10, 80);
            rotation.x = _elevation;
            _boom.transform.localEulerAngles = rotation;
        }

        private void UpdateRotation()
        {
            var rotation = transform.localEulerAngles;
            _rotation %= 360;
            rotation.y = _rotation;
            transform.localEulerAngles = rotation;
        }


        private void OnValidate()
        {
            _elevation = Mathf.Clamp(_elevation, 10, 80);
            _zoom = Mathf.Clamp(_zoom, _minZoom, _maxZoom);
            _targetZoom = _zoom;
        }
    }
}