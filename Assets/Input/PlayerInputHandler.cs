// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputHandler.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputHandler : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputHandler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputHandler"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""0196dc1e-153b-494a-8d5d-c4e0d7c3a642"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""82492890-a2e8-42f5-8d8f-6808d4cc2bee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""f5bb39a0-e702-436f-a502-dba68dd60793"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""785ef796-fc66-4b57-8392-e61f709ff5a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dfa0b023-b1c7-4211-bedd-d94c84cd7197"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f21336ba-f5d0-4496-87db-da025f205ddd"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0fd6de3-1ed3-4fe1-88c1-7c0871ea2225"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1840002f-1063-4adb-a594-57a36dde51b9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b6d7db3-2796-4fbe-acde-694a784b7756"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c73cf2a-cdab-4677-a535-55c591d373e5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LockPicking"",
            ""id"": ""a42042ac-3350-44d7-b5ee-ed1f7552b176"",
            ""actions"": [
                {
                    ""name"": ""PickXY"",
                    ""type"": ""Value"",
                    ""id"": ""dd701b62-f711-4af9-a0dc-e6854707984e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickZ"",
                    ""type"": ""Value"",
                    ""id"": ""9dffd47e-3f73-4a7b-8252-d0fe47ad6c2f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickRotation"",
                    ""type"": ""Value"",
                    ""id"": ""d6dd3bf2-494a-4371-9274-4613a3fd9582"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlugRotation"",
                    ""type"": ""Button"",
                    ""id"": ""bec9cf12-75e3-458a-a614-9c060bbeac24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""db97397f-6229-4842-b122-69956c3aa863"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PickXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f4aad38-22ff-4e8d-bb90-571aa60537fa"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Triggers"",
                    ""id"": ""5f009d1f-3594-4b65-a858-4ff119b37dba"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1c9a8405-5029-4f72-835b-e9a02dabff34"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PickZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3565e786-9523-4694-bb0c-abc3105e965c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PickZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd735064-0d97-4913-89bc-274583dac545"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(max=10)"",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2de20384-1e62-4aec-bd03-f2423d6c4efa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ShoulderButtons"",
                    ""id"": ""dac48b51-6559-410a-a06f-924ca245f260"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=15)"",
                    ""groups"": """",
                    ""action"": ""PlugRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1da91f63-8793-4bc2-8d86-b3301937231b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PlugRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9942493c-bab9-4754-9ccd-4de1f8be11bf"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PlugRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""QE"",
                    ""id"": ""ef31bd19-9fe8-4b38-b0df-431f125040e6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlugRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9b2c4c56-81ae-4c01-b190-e9cd6e94610b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlugRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b274b84a-98ec-4aed-a50e-c1bf409e1240"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PlugRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""1c15cd11-ba38-49ca-9e83-00fdec16d788"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=15,y=15)"",
                    ""groups"": """",
                    ""action"": ""PickRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a6ff27d-901a-4307-8360-e3600a178a4f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c53bfea8-968c-48b5-ba20-5d12879b6a48"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e645d77a-23d4-47f8-b9a5-78324dde7c6c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""87a380b0-2a62-47f8-a5b8-7fa2857a6960"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""PickRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""c1b333d2-158c-4f0b-9099-8ab2782bbe9e"",
            ""actions"": [
                {
                    ""name"": ""CameraControl"",
                    ""type"": ""Value"",
                    ""id"": ""2e870203-cec0-44c4-8ae9-265ee8bf4ccc"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7776bce-c650-427a-b74b-b71cb527e031"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=25,y=25),InvertVector2"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
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
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Confirm = m_Menu.FindAction("Confirm", throwIfNotFound: true);
        m_Menu_Back = m_Menu.FindAction("Back", throwIfNotFound: true);
        m_Menu_Menu = m_Menu.FindAction("Menu", throwIfNotFound: true);
        // LockPicking
        m_LockPicking = asset.FindActionMap("LockPicking", throwIfNotFound: true);
        m_LockPicking_PickXY = m_LockPicking.FindAction("PickXY", throwIfNotFound: true);
        m_LockPicking_PickZ = m_LockPicking.FindAction("PickZ", throwIfNotFound: true);
        m_LockPicking_PickRotation = m_LockPicking.FindAction("PickRotation", throwIfNotFound: true);
        m_LockPicking_PlugRotation = m_LockPicking.FindAction("PlugRotation", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_CameraControl = m_Camera.FindAction("CameraControl", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Confirm;
    private readonly InputAction m_Menu_Back;
    private readonly InputAction m_Menu_Menu;
    public struct MenuActions
    {
        private @PlayerInputHandler m_Wrapper;
        public MenuActions(@PlayerInputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_Menu_Confirm;
        public InputAction @Back => m_Wrapper.m_Menu_Back;
        public InputAction @Menu => m_Wrapper.m_Menu_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                @Back.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnBack;
                @Menu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // LockPicking
    private readonly InputActionMap m_LockPicking;
    private ILockPickingActions m_LockPickingActionsCallbackInterface;
    private readonly InputAction m_LockPicking_PickXY;
    private readonly InputAction m_LockPicking_PickZ;
    private readonly InputAction m_LockPicking_PickRotation;
    private readonly InputAction m_LockPicking_PlugRotation;
    public struct LockPickingActions
    {
        private @PlayerInputHandler m_Wrapper;
        public LockPickingActions(@PlayerInputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @PickXY => m_Wrapper.m_LockPicking_PickXY;
        public InputAction @PickZ => m_Wrapper.m_LockPicking_PickZ;
        public InputAction @PickRotation => m_Wrapper.m_LockPicking_PickRotation;
        public InputAction @PlugRotation => m_Wrapper.m_LockPicking_PlugRotation;
        public InputActionMap Get() { return m_Wrapper.m_LockPicking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LockPickingActions set) { return set.Get(); }
        public void SetCallbacks(ILockPickingActions instance)
        {
            if (m_Wrapper.m_LockPickingActionsCallbackInterface != null)
            {
                @PickXY.started -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickXY;
                @PickXY.performed -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickXY;
                @PickXY.canceled -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickXY;
                @PickZ.started -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickZ;
                @PickZ.performed -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickZ;
                @PickZ.canceled -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickZ;
                @PickRotation.started -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickRotation;
                @PickRotation.performed -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickRotation;
                @PickRotation.canceled -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPickRotation;
                @PlugRotation.started -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPlugRotation;
                @PlugRotation.performed -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPlugRotation;
                @PlugRotation.canceled -= m_Wrapper.m_LockPickingActionsCallbackInterface.OnPlugRotation;
            }
            m_Wrapper.m_LockPickingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PickXY.started += instance.OnPickXY;
                @PickXY.performed += instance.OnPickXY;
                @PickXY.canceled += instance.OnPickXY;
                @PickZ.started += instance.OnPickZ;
                @PickZ.performed += instance.OnPickZ;
                @PickZ.canceled += instance.OnPickZ;
                @PickRotation.started += instance.OnPickRotation;
                @PickRotation.performed += instance.OnPickRotation;
                @PickRotation.canceled += instance.OnPickRotation;
                @PlugRotation.started += instance.OnPlugRotation;
                @PlugRotation.performed += instance.OnPlugRotation;
                @PlugRotation.canceled += instance.OnPlugRotation;
            }
        }
    }
    public LockPickingActions @LockPicking => new LockPickingActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_CameraControl;
    public struct CameraActions
    {
        private @PlayerInputHandler m_Wrapper;
        public CameraActions(@PlayerInputHandler wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraControl => m_Wrapper.m_Camera_CameraControl;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @CameraControl.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraControl;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IMenuActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface ILockPickingActions
    {
        void OnPickXY(InputAction.CallbackContext context);
        void OnPickZ(InputAction.CallbackContext context);
        void OnPickRotation(InputAction.CallbackContext context);
        void OnPlugRotation(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnCameraControl(InputAction.CallbackContext context);
    }
}
