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
            ""name"": ""Player0"",
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
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""5a48d09a-ace2-42c4-8ed6-332018beb16d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""04768c9f-adaf-443a-88cf-8e144fb1076e"",
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
                    ""id"": ""792afa93-1abe-4b04-bb34-6ef3eef667f7"",
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
                    ""id"": ""2907dcf1-7f8c-41ba-aceb-914dfa5ae619"",
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
                    ""id"": ""a91a3cc8-4eea-4d9c-b042-8cdabd5126f5"",
                    ""expectedControlLayout"": ""Button"",
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
                    ""id"": ""4af23d4d-92c6-4e5e-bde7-e5441baa7a92"",
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
                    ""id"": ""62dedf44-165e-4ca1-b711-b470ce7c1ad6"",
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
                    ""id"": ""9dc2803a-eaa7-4021-bd5e-54ec5d1f4045"",
                    ""path"": ""<Keyboard>/upArrow"",
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
                    ""id"": ""0fc81048-cc45-466a-807f-da598a460845"",
                    ""path"": ""<Keyboard>/downArrow"",
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
                    ""id"": ""67fd47b2-4d20-464b-a10f-500de2c90374"",
                    ""path"": ""<Keyboard>/leftArrow"",
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
                    ""id"": ""bf50306b-1bef-430e-977c-1c9da57243e9"",
                    ""path"": ""<Keyboard>/rightArrow"",
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
                    ""id"": ""cc4ca131-8f62-4be8-a94e-576368fd86d7"",
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
                    ""id"": ""5fe8462e-2beb-4a62-b67c-b7c12cf96713"",
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
                    ""id"": ""6960a8c0-ec32-4cad-b192-e3e1406405aa"",
                    ""path"": ""<Keyboard>/o"",
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
                    ""id"": ""0df13e02-1fc6-436f-942c-bc52ae4663ee"",
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
                    ""id"": ""80993a08-7e6a-4f16-8efd-e2862a40da49"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
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
            // Player0
            m_Player0 = asset.GetActionMap("Player0");
            m_Player0_Movement = m_Player0.GetAction("Movement");
            m_Player0_Target = m_Player0.GetAction("Target");
            m_Player0_Fire = m_Player0.GetAction("Fire");
            m_Player0_Dash = m_Player0.GetAction("Dash");
            // Player1
            m_Player1 = asset.GetActionMap("Player1");
            m_Player1_Movement = m_Player1.GetAction("Movement");
            m_Player1_Target = m_Player1.GetAction("Target");
            m_Player1_Fire = m_Player1.GetAction("Fire");
            m_Player1_Dash = m_Player1.GetAction("Dash");
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
        // Player0
        private InputActionMap m_Player0;
        private IPlayer0Actions m_Player0ActionsCallbackInterface;
        private InputAction m_Player0_Movement;
        private InputAction m_Player0_Target;
        private InputAction m_Player0_Fire;
        private InputAction m_Player0_Dash;
        public struct Player0Actions
        {
            private IngameInputActions m_Wrapper;
            public Player0Actions(IngameInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement { get { return m_Wrapper.m_Player0_Movement; } }
            public InputAction @Target { get { return m_Wrapper.m_Player0_Target; } }
            public InputAction @Fire { get { return m_Wrapper.m_Player0_Fire; } }
            public InputAction @Dash { get { return m_Wrapper.m_Player0_Dash; } }
            public InputActionMap Get() { return m_Wrapper.m_Player0; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled { get { return Get().enabled; } }
            public InputActionMap Clone() { return Get().Clone(); }
            public static implicit operator InputActionMap(Player0Actions set) { return set.Get(); }
            public void SetCallbacks(IPlayer0Actions instance)
            {
                if (m_Wrapper.m_Player0ActionsCallbackInterface != null)
                {
                    Movement.started -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMovement;
                    Movement.performed -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMovement;
                    Movement.cancelled -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMovement;
                    Target.started -= m_Wrapper.m_Player0ActionsCallbackInterface.OnTarget;
                    Target.performed -= m_Wrapper.m_Player0ActionsCallbackInterface.OnTarget;
                    Target.cancelled -= m_Wrapper.m_Player0ActionsCallbackInterface.OnTarget;
                    Fire.started -= m_Wrapper.m_Player0ActionsCallbackInterface.OnFire;
                    Fire.performed -= m_Wrapper.m_Player0ActionsCallbackInterface.OnFire;
                    Fire.cancelled -= m_Wrapper.m_Player0ActionsCallbackInterface.OnFire;
                    Dash.started -= m_Wrapper.m_Player0ActionsCallbackInterface.OnDash;
                    Dash.performed -= m_Wrapper.m_Player0ActionsCallbackInterface.OnDash;
                    Dash.cancelled -= m_Wrapper.m_Player0ActionsCallbackInterface.OnDash;
                }
                m_Wrapper.m_Player0ActionsCallbackInterface = instance;
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
                }
            }
        }
        public Player0Actions @Player0
        {
            get
            {
                return new Player0Actions(this);
            }
        }
        // Player1
        private InputActionMap m_Player1;
        private IPlayer1Actions m_Player1ActionsCallbackInterface;
        private InputAction m_Player1_Movement;
        private InputAction m_Player1_Target;
        private InputAction m_Player1_Fire;
        private InputAction m_Player1_Dash;
        public struct Player1Actions
        {
            private IngameInputActions m_Wrapper;
            public Player1Actions(IngameInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement { get { return m_Wrapper.m_Player1_Movement; } }
            public InputAction @Target { get { return m_Wrapper.m_Player1_Target; } }
            public InputAction @Fire { get { return m_Wrapper.m_Player1_Fire; } }
            public InputAction @Dash { get { return m_Wrapper.m_Player1_Dash; } }
            public InputActionMap Get() { return m_Wrapper.m_Player1; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled { get { return Get().enabled; } }
            public InputActionMap Clone() { return Get().Clone(); }
            public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
            public void SetCallbacks(IPlayer1Actions instance)
            {
                if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
                {
                    Movement.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                    Movement.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                    Movement.cancelled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMovement;
                    Target.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTarget;
                    Target.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTarget;
                    Target.cancelled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTarget;
                    Fire.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFire;
                    Fire.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFire;
                    Fire.cancelled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFire;
                    Dash.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                    Dash.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                    Dash.cancelled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDash;
                }
                m_Wrapper.m_Player1ActionsCallbackInterface = instance;
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
                }
            }
        }
        public Player1Actions @Player1
        {
            get
            {
                return new Player1Actions(this);
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
        public interface IPlayer0Actions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnTarget(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
        }
        public interface IPlayer1Actions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnTarget(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
        }
    }
}
