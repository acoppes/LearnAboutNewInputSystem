// GENERATED AUTOMATICALLY FROM 'Assets/IngameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Utilities;

namespace Gemserk.Learn.Input
{
    public class IngameInputActions : IInputActionCollection
    {
        private InputActionAsset asset;
        public IngameInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""IngameInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5e74236e-9b04-4a59-8451-b4bb24ab9b41"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""8c27fdf8-f459-4983-963a-0ad9ec9865f0"",
                    ""expectedControlLayout"": ""Axis"",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Target"",
                    ""id"": ""1419c929-af52-45ad-aa56-e1f112ebbe8d"",
                    ""expectedControlLayout"": ""Axis"",
                    ""continuous"": true,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Fire"",
                    ""id"": ""39aeff59-94f0-4caf-8a6b-990dadc0ccd7"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Dash"",
                    ""id"": ""171a7275-0792-4830-9fda-fe4d8e276fa0"",
                    ""expectedControlLayout"": ""Button"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Join"",
                    ""id"": ""c431dcdd-2087-416d-8912-00d2cb59d159"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10221a74-504a-4c4c-97a5-47e95559e07d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""473068a5-83a7-4099-8048-5761b09220f8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3878d8b5-862b-41fb-8984-83c5af743ed8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b6124f50-4bc2-40da-aacc-6946ae4e8dce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06ee7f5b-a8dd-4b76-8ea8-5df4eb11e3c2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1c8a5e0a-069f-4ad2-85f3-a78500b1fce3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""b06fe151-b675-455d-b48a-25ca43f5a790"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""fa9485bc-334f-47b8-a369-f3a4067e5c0f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""737f1eac-1461-4109-9b89-8ca76c1dcefe"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ff0aa978-db1a-430f-9fba-8da3b9f46b88"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""bee1f470-f1ae-4b80-af2f-34da77dbc96d"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""8dfe7566-46f1-44af-8987-d5df9316237c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""ControlSchema"",
            ""basedOn"": """",
            ""bindingGroup"": ""ControlSchema"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player
            m_Player = asset.GetActionMap("Player");
            m_Player_Movement = m_Player.GetAction("Movement");
            m_Player_Target = m_Player.GetAction("Target");
            m_Player_Fire = m_Player.GetAction("Fire");
            m_Player_Dash = m_Player.GetAction("Dash");
            m_Player_Join = m_Player.GetAction("Join");
        }
        ~IngameInputActions()
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
        public ReadOnlyArray<InputControlScheme> controlSchemes
        {
            get => asset.controlSchemes;
        }
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
        // Player
        private InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private InputAction m_Player_Movement;
        private InputAction m_Player_Target;
        private InputAction m_Player_Fire;
        private InputAction m_Player_Dash;
        private InputAction m_Player_Join;
        public struct PlayerActions
        {
            private IngameInputActions m_Wrapper;
            public PlayerActions(IngameInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement { get { return m_Wrapper.m_Player_Movement; } }
            public InputAction @Target { get { return m_Wrapper.m_Player_Target; } }
            public InputAction @Fire { get { return m_Wrapper.m_Player_Fire; } }
            public InputAction @Dash { get { return m_Wrapper.m_Player_Dash; } }
            public InputAction @Join { get { return m_Wrapper.m_Player_Join; } }
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled { get { return Get().enabled; } }
            public InputActionMap Clone() { return Get().Clone(); }
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    Movement.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    Target.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTarget;
                    Target.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTarget;
                    Target.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTarget;
                    Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                    Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                    Fire.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                    Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                    Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                    Dash.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                    Join.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoin;
                    Join.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoin;
                    Join.cancelled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoin;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Movement.started += instance.OnMovement;
                    Movement.performed += instance.OnMovement;
                    Movement.cancelled += instance.OnMovement;
                    Target.started += instance.OnTarget;
                    Target.performed += instance.OnTarget;
                    Target.cancelled += instance.OnTarget;
                    Fire.started += instance.OnFire;
                    Fire.performed += instance.OnFire;
                    Fire.cancelled += instance.OnFire;
                    Dash.started += instance.OnDash;
                    Dash.performed += instance.OnDash;
                    Dash.cancelled += instance.OnDash;
                    Join.started += instance.OnJoin;
                    Join.performed += instance.OnJoin;
                    Join.cancelled += instance.OnJoin;
                }
            }
        }
        public PlayerActions @Player
        {
            get
            {
                return new PlayerActions(this);
            }
        }
        private int m_ControlSchemaSchemeIndex = -1;
        public InputControlScheme ControlSchemaScheme
        {
            get
            {
                if (m_ControlSchemaSchemeIndex == -1) m_ControlSchemaSchemeIndex = asset.GetControlSchemeIndex("ControlSchema");
                return asset.controlSchemes[m_ControlSchemaSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnTarget(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
            void OnJoin(InputAction.CallbackContext context);
        }
    }
}
