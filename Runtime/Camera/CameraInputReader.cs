using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

namespace SteveJstone
{
	[CreateAssetMenu(fileName = "CameraInputReader", menuName = "SteveJstone/Camera Input Reader")]
	public class CameraInputReader : DescriptionBaseSO, CameraControls.ICameraActions
	{
		public event UnityAction<Vector2> CameraMoveEvent = delegate { };
		public event UnityAction<float> CameraZoomEvent = delegate { };
		public event UnityAction CameraRotateLeftEvent = delegate { };
		public event UnityAction CameraRotateRightEvent = delegate { };
		public event UnityAction CameraRotateEvent = delegate { };

		private CameraControls _controls;

		private void OnEnable()
		{
			//Debug.Log("InputReader.OnEnable");
			if (_controls == null)
			{
				_controls = new CameraControls();
				_controls.Camera.SetCallbacks(this);
				_controls.Camera.Enable();
			}
		}

		private void OnDisable()
		{
			DisableAllInput();
		}

		public void DisableAllInput()
		{
			_controls.Camera.Disable();
		}

		public bool LeftMouseDown => Mouse.current.leftButton.isPressed;
		public bool MiddleMouseDown => Mouse.current.middleButton.isPressed;

		public void OnCameraZoom(InputAction.CallbackContext context)
		{
			//Debug.Log(nameof(OnCameraZoom));
			CameraZoomEvent?.Invoke(context.ReadValue<float>());
		}

		public void OnCameraMove(InputAction.CallbackContext context)
		{
			//Debug.Log(nameof(OnCameraMove));
			CameraMoveEvent?.Invoke(context.ReadValue<Vector2>());
		}

		public void OnLook(InputAction.CallbackContext context)
		{
			Debug.Log("InputReader.OnLook");
		}

		public void OnFire(InputAction.CallbackContext context)
		{
			Debug.Log("InputReader.OnFire");
		}

		public void OnMove(InputAction.CallbackContext context)
		{
			Debug.Log("InputReader.OnMove");
		}

		public void OnRotateCameraLeft(InputAction.CallbackContext context)
		{
			CameraRotateLeftEvent?.Invoke();
		}

		public void OnRotateCameraRight(InputAction.CallbackContext context)
		{
			CameraRotateRightEvent?.Invoke();
		}

		public void OnRotateCamera(InputAction.CallbackContext context)
		{
			CameraRotateEvent?.Invoke();
		}
	}
}