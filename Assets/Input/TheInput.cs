// GENERATED AUTOMATICALLY FROM 'Assets/Input/TheInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TheInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TheInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TheInput"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""3e22e72c-2d27-4bbc-8a1b-113cd9efeeed"",
            ""actions"": [
                {
                    ""name"": ""Motion"",
                    ""type"": ""Value"",
                    ""id"": ""6944b6c9-9d26-4715-85af-71ed1ad7bfb9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoystickAim"",
                    ""type"": ""Value"",
                    ""id"": ""cd7db644-9838-4b7a-8b93-6f12dcb73559"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""92a7f4c6-ac5f-4289-8d5a-542e196df0e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseAim"",
                    ""type"": ""Value"",
                    ""id"": ""a0d17faa-52bd-462e-9dfc-f27f7805fd1a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GamepadUseIndicator"",
                    ""type"": ""Value"",
                    ""id"": ""1e77b6d4-b2cf-4a45-89b4-8280fc86eefb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardUseIndicator"",
                    ""type"": ""Button"",
                    ""id"": ""a42a8ff2-4609-4a41-adf4-c42f004e9006"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""01e5e3be-8bf7-4a33-a5ea-7b6f99378fab"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ffb0732b-902b-4737-9fc6-9cc063ad85fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f37fa333-a428-4049-a41c-dc34cf3cc393"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cfada975-695f-47c7-a221-40d6af6b157b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e24dca92-fac7-4227-9aa5-b52aad697d59"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9e23afe3-9e1f-4e79-94b6-a0d6140272d0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f089189a-cac1-4d2b-b045-dcd6960035da"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4c90a8a-d6b6-45d2-88e5-740ad7c4592b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff047356-0c59-4852-89bf-73609aac2f32"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42ec46b2-4fa3-4ff2-aaee-0eef45f33fdf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c409ace0-c168-4961-86e9-95d1022b5eb8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GamepadUseIndicator"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64b70dc2-4e9e-408f-86e6-c24fd5ed1d89"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GamepadUseIndicator"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b693eec-d597-48df-9872-bd254039fc2e"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardUseIndicator"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Motion = m_PlayerControl.FindAction("Motion", throwIfNotFound: true);
        m_PlayerControl_JoystickAim = m_PlayerControl.FindAction("JoystickAim", throwIfNotFound: true);
        m_PlayerControl_Fire = m_PlayerControl.FindAction("Fire", throwIfNotFound: true);
        m_PlayerControl_MouseAim = m_PlayerControl.FindAction("MouseAim", throwIfNotFound: true);
        m_PlayerControl_GamepadUseIndicator = m_PlayerControl.FindAction("GamepadUseIndicator", throwIfNotFound: true);
        m_PlayerControl_KeyboardUseIndicator = m_PlayerControl.FindAction("KeyboardUseIndicator", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Motion;
    private readonly InputAction m_PlayerControl_JoystickAim;
    private readonly InputAction m_PlayerControl_Fire;
    private readonly InputAction m_PlayerControl_MouseAim;
    private readonly InputAction m_PlayerControl_GamepadUseIndicator;
    private readonly InputAction m_PlayerControl_KeyboardUseIndicator;
    public struct PlayerControlActions
    {
        private @TheInput m_Wrapper;
        public PlayerControlActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Motion => m_Wrapper.m_PlayerControl_Motion;
        public InputAction @JoystickAim => m_Wrapper.m_PlayerControl_JoystickAim;
        public InputAction @Fire => m_Wrapper.m_PlayerControl_Fire;
        public InputAction @MouseAim => m_Wrapper.m_PlayerControl_MouseAim;
        public InputAction @GamepadUseIndicator => m_Wrapper.m_PlayerControl_GamepadUseIndicator;
        public InputAction @KeyboardUseIndicator => m_Wrapper.m_PlayerControl_KeyboardUseIndicator;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Motion.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMotion;
                @Motion.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMotion;
                @Motion.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMotion;
                @JoystickAim.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJoystickAim;
                @JoystickAim.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJoystickAim;
                @JoystickAim.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnJoystickAim;
                @Fire.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnFire;
                @MouseAim.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMouseAim;
                @MouseAim.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMouseAim;
                @MouseAim.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMouseAim;
                @GamepadUseIndicator.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnGamepadUseIndicator;
                @GamepadUseIndicator.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnGamepadUseIndicator;
                @GamepadUseIndicator.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnGamepadUseIndicator;
                @KeyboardUseIndicator.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnKeyboardUseIndicator;
                @KeyboardUseIndicator.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnKeyboardUseIndicator;
                @KeyboardUseIndicator.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnKeyboardUseIndicator;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Motion.started += instance.OnMotion;
                @Motion.performed += instance.OnMotion;
                @Motion.canceled += instance.OnMotion;
                @JoystickAim.started += instance.OnJoystickAim;
                @JoystickAim.performed += instance.OnJoystickAim;
                @JoystickAim.canceled += instance.OnJoystickAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @MouseAim.started += instance.OnMouseAim;
                @MouseAim.performed += instance.OnMouseAim;
                @MouseAim.canceled += instance.OnMouseAim;
                @GamepadUseIndicator.started += instance.OnGamepadUseIndicator;
                @GamepadUseIndicator.performed += instance.OnGamepadUseIndicator;
                @GamepadUseIndicator.canceled += instance.OnGamepadUseIndicator;
                @KeyboardUseIndicator.started += instance.OnKeyboardUseIndicator;
                @KeyboardUseIndicator.performed += instance.OnKeyboardUseIndicator;
                @KeyboardUseIndicator.canceled += instance.OnKeyboardUseIndicator;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    public interface IPlayerControlActions
    {
        void OnMotion(InputAction.CallbackContext context);
        void OnJoystickAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnMouseAim(InputAction.CallbackContext context);
        void OnGamepadUseIndicator(InputAction.CallbackContext context);
        void OnKeyboardUseIndicator(InputAction.CallbackContext context);
    }
}
