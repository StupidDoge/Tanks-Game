//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_TankGame/Scripts/Core/Services/Input/Player Input.inputactions
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

namespace Core.Services.Input
{
    public partial class @PlayerControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Input"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""bcd1784b-3132-4791-ae5e-83a8df3fd436"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""9f1c14d8-773c-44ed-8d43-cf0e83f2168f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""23a6f257-6937-4884-8020-9c7b91f61eac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseLeftButtonClick"",
                    ""type"": ""Button"",
                    ""id"": ""83de7cc6-d7a9-474e-a593-a41e1656cdd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChooseFirstProjectileType"",
                    ""type"": ""Button"",
                    ""id"": ""8a454f66-ed15-4e6c-90d7-cc57b28f5e60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChooseSecondProjectileType"",
                    ""type"": ""Button"",
                    ""id"": ""dfb68913-8952-4796-8d59-927c601ff0ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c87916f3-3a02-43d7-b0bf-ba1ac2c78a54"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5fba33c7-c8e8-4711-a041-34a197d6b5c3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8dfa7e2b-134c-413d-8b23-70adfcb1a851"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d43bfd21-ac76-40d2-80d2-13379d1f7b98"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7e9fdfef-f5d5-4782-a70e-f53963c1e44b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""37227d79-9586-4eb1-ac21-98d4e6421188"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cef6599b-a4fc-4106-9c88-223f7093942c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLeftButtonClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86379e1e-66d0-4f89-8085-2f80ad918194"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseFirstProjectileType"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e89e9a5b-6fc6-4c69-acb6-3216d5257b28"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseSecondProjectileType"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
            m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
            m_Player_MouseLeftButtonClick = m_Player.FindAction("MouseLeftButtonClick", throwIfNotFound: true);
            m_Player_ChooseFirstProjectileType = m_Player.FindAction("ChooseFirstProjectileType", throwIfNotFound: true);
            m_Player_ChooseSecondProjectileType = m_Player.FindAction("ChooseSecondProjectileType", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
        private readonly InputAction m_Player_Movement;
        private readonly InputAction m_Player_MousePosition;
        private readonly InputAction m_Player_MouseLeftButtonClick;
        private readonly InputAction m_Player_ChooseFirstProjectileType;
        private readonly InputAction m_Player_ChooseSecondProjectileType;
        public struct PlayerActions
        {
            private @PlayerControls m_Wrapper;
            public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Movement;
            public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
            public InputAction @MouseLeftButtonClick => m_Wrapper.m_Player_MouseLeftButtonClick;
            public InputAction @ChooseFirstProjectileType => m_Wrapper.m_Player_ChooseFirstProjectileType;
            public InputAction @ChooseSecondProjectileType => m_Wrapper.m_Player_ChooseSecondProjectileType;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @MouseLeftButtonClick.started += instance.OnMouseLeftButtonClick;
                @MouseLeftButtonClick.performed += instance.OnMouseLeftButtonClick;
                @MouseLeftButtonClick.canceled += instance.OnMouseLeftButtonClick;
                @ChooseFirstProjectileType.started += instance.OnChooseFirstProjectileType;
                @ChooseFirstProjectileType.performed += instance.OnChooseFirstProjectileType;
                @ChooseFirstProjectileType.canceled += instance.OnChooseFirstProjectileType;
                @ChooseSecondProjectileType.started += instance.OnChooseSecondProjectileType;
                @ChooseSecondProjectileType.performed += instance.OnChooseSecondProjectileType;
                @ChooseSecondProjectileType.canceled += instance.OnChooseSecondProjectileType;
            }

            private void UnregisterCallbacks(IPlayerActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @MousePosition.started -= instance.OnMousePosition;
                @MousePosition.performed -= instance.OnMousePosition;
                @MousePosition.canceled -= instance.OnMousePosition;
                @MouseLeftButtonClick.started -= instance.OnMouseLeftButtonClick;
                @MouseLeftButtonClick.performed -= instance.OnMouseLeftButtonClick;
                @MouseLeftButtonClick.canceled -= instance.OnMouseLeftButtonClick;
                @ChooseFirstProjectileType.started -= instance.OnChooseFirstProjectileType;
                @ChooseFirstProjectileType.performed -= instance.OnChooseFirstProjectileType;
                @ChooseFirstProjectileType.canceled -= instance.OnChooseFirstProjectileType;
                @ChooseSecondProjectileType.started -= instance.OnChooseSecondProjectileType;
                @ChooseSecondProjectileType.performed -= instance.OnChooseSecondProjectileType;
                @ChooseSecondProjectileType.canceled -= instance.OnChooseSecondProjectileType;
            }

            public void RemoveCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnMousePosition(InputAction.CallbackContext context);
            void OnMouseLeftButtonClick(InputAction.CallbackContext context);
            void OnChooseFirstProjectileType(InputAction.CallbackContext context);
            void OnChooseSecondProjectileType(InputAction.CallbackContext context);
        }
    }
}
