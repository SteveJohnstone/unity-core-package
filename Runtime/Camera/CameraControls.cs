//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Packages/com.stevejstone.core/Runtime/Camera/CameraControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CameraControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CameraControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CameraControls"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""8ad0bdbe-ef0e-4ed8-b3ec-7ed97bd21cf9"",
            ""actions"": [
                {
                    ""name"": ""CameraZoom"",
                    ""type"": ""Value"",
                    ""id"": ""ab0444e4-542a-42a8-96c1-61c2c7080e90"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Scale(factor=10)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f5f87845-d2e3-478a-80cb-36b57f968343"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RotateCameraLeft"",
                    ""type"": ""Button"",
                    ""id"": ""98be40d4-fef3-4b62-aacc-ce5303b1dbad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateCameraRight"",
                    ""type"": ""Button"",
                    ""id"": ""997908b8-4508-45f1-9e19-ca0abddecc81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Button"",
                    ""id"": ""3af73cdb-7342-484b-bce5-f42cda3874ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2be2f5c6-cfc7-4c81-9061-d889e300bdf9"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CameraZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dec87e5b-590a-4062-9352-c3f00c1d4ee4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""978b3f79-f283-4257-aea9-97f01ff283bc"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4433bc02-9668-4399-b47f-791d2648610a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d0496a3d-6915-4604-94d8-0a90f20a63f2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""05f0a142-4e6b-4552-bfa3-8f56514b04fe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""99c83a33-3d86-4a3d-8a6d-c99b675f3c8e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""163b6771-c831-44db-badd-94c9218a72ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""90c2bb57-2476-4c1a-a76a-caecad713093"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bcb21702-a2a2-47f2-a0d3-53b6e737a595"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""62eb287a-3b9a-4fd5-bbb7-d55b659d988f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""47444899-b78b-4c15-bd89-d250cf3e0f2b"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8819439-db29-4dd6-90c3-620da088e70c"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cec5a32-a69e-4516-aa47-6b9fd1f23c93"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCameraLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59d77f67-e73b-49b9-8568-5851211748a6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCameraRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecbd1d3f-d58c-4284-ab35-c056862dd9d3"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_CameraZoom = m_Camera.FindAction("CameraZoom", throwIfNotFound: true);
        m_Camera_CameraMove = m_Camera.FindAction("CameraMove", throwIfNotFound: true);
        m_Camera_RotateCameraLeft = m_Camera.FindAction("RotateCameraLeft", throwIfNotFound: true);
        m_Camera_RotateCameraRight = m_Camera.FindAction("RotateCameraRight", throwIfNotFound: true);
        m_Camera_RotateCamera = m_Camera.FindAction("RotateCamera", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_CameraZoom;
    private readonly InputAction m_Camera_CameraMove;
    private readonly InputAction m_Camera_RotateCameraLeft;
    private readonly InputAction m_Camera_RotateCameraRight;
    private readonly InputAction m_Camera_RotateCamera;
    public struct CameraActions
    {
        private @CameraControls m_Wrapper;
        public CameraActions(@CameraControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraZoom => m_Wrapper.m_Camera_CameraZoom;
        public InputAction @CameraMove => m_Wrapper.m_Camera_CameraMove;
        public InputAction @RotateCameraLeft => m_Wrapper.m_Camera_RotateCameraLeft;
        public InputAction @RotateCameraRight => m_Wrapper.m_Camera_RotateCameraRight;
        public InputAction @RotateCamera => m_Wrapper.m_Camera_RotateCamera;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @CameraZoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraZoom;
                @CameraZoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraZoom;
                @CameraMove.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraMove;
                @CameraMove.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraMove;
                @CameraMove.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraMove;
                @RotateCameraLeft.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCameraLeft;
                @RotateCameraLeft.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCameraLeft;
                @RotateCameraLeft.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCameraLeft;
                @RotateCameraRight.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCameraRight;
                @RotateCameraRight.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCameraRight;
                @RotateCameraRight.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCameraRight;
                @RotateCamera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCamera;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraZoom.started += instance.OnCameraZoom;
                @CameraZoom.performed += instance.OnCameraZoom;
                @CameraZoom.canceled += instance.OnCameraZoom;
                @CameraMove.started += instance.OnCameraMove;
                @CameraMove.performed += instance.OnCameraMove;
                @CameraMove.canceled += instance.OnCameraMove;
                @RotateCameraLeft.started += instance.OnRotateCameraLeft;
                @RotateCameraLeft.performed += instance.OnRotateCameraLeft;
                @RotateCameraLeft.canceled += instance.OnRotateCameraLeft;
                @RotateCameraRight.started += instance.OnRotateCameraRight;
                @RotateCameraRight.performed += instance.OnRotateCameraRight;
                @RotateCameraRight.canceled += instance.OnRotateCameraRight;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface ICameraActions
    {
        void OnCameraZoom(InputAction.CallbackContext context);
        void OnCameraMove(InputAction.CallbackContext context);
        void OnRotateCameraLeft(InputAction.CallbackContext context);
        void OnRotateCameraRight(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
    }
}
