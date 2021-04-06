// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e2d55949-683c-434f-a576-dfed7de5fad6"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""ebcc3ab2-afea-4630-80f9-bf14aa5dfacc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""335b51f3-5f94-4861-be42-4601289db4d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Power"",
                    ""type"": ""Button"",
                    ""id"": ""262cb53f-5b92-41cc-b073-a1cd605708a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CicleDown"",
                    ""type"": ""Button"",
                    ""id"": ""52205eb2-8786-4625-91aa-92b43a352ce1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CicleUp"",
                    ""type"": ""Button"",
                    ""id"": ""032866bd-d7fc-47ac-9330-b88da930f614"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""89b8d52e-c742-4a35-9153-b40280178321"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1ff24a1b-471d-423a-9291-21078c811ec5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cf91555a-eded-4da4-9dd3-b1b6d86f728b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f7258e44-e4ed-4a8f-91e2-5dccfdfdf39a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bef7dbea-992f-4d39-80d2-dc26eecc07fc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""79d6e058-188a-42d4-89b2-540e55336000"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb0562aa-1a62-48f0-816f-417f254842b1"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f41ec9a8-b2e9-454f-ac51-a383b59e728b"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CicleDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27672a47-494c-41ab-90a6-a97b320d4ac8"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CicleUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""e9880815-b9f3-4361-8acf-f2bc034a74af"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""903ec7fe-66a8-4c0a-882b-f44c8536d141"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""6084b93f-18c1-440b-9393-c2d00c58d4c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Power"",
                    ""type"": ""Button"",
                    ""id"": ""62ae706a-eb66-40fc-a3f4-fbd79a0960e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CicleDown"",
                    ""type"": ""Button"",
                    ""id"": ""2de00904-8f63-487a-ad0e-71e5d7d324a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CicleUp"",
                    ""type"": ""Button"",
                    ""id"": ""e778f276-3348-40aa-bb96-1aa95dabc602"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1afc263d-061a-4dca-b68a-fb92ffeed0a3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7efa3d8e-5696-47d9-9154-799a4f4a62b9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""846b23cb-512c-4692-a7af-6e57d4972fda"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a661eb71-a9c5-4ecd-9f3c-372ef405799a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f7022d54-c425-4e98-b5ee-1716ef598dee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5f771586-54e8-4753-b43e-e54d0b327764"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dd7a60b1-5a7a-4489-b10a-d56050971f0c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f14326dc-6ef1-4eb3-b230-1ac39bc74495"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CicleDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c508fb-d98c-458a-a585-9cbe48b50cfe"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CicleUp"",
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
        m_Player_Horizontal = m_Player.FindAction("Horizontal", throwIfNotFound: true);
        m_Player_Vertical = m_Player.FindAction("Vertical", throwIfNotFound: true);
        m_Player_Power = m_Player.FindAction("Power", throwIfNotFound: true);
        m_Player_CicleDown = m_Player.FindAction("CicleDown", throwIfNotFound: true);
        m_Player_CicleUp = m_Player.FindAction("CicleUp", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Horizontal = m_Player2.FindAction("Horizontal", throwIfNotFound: true);
        m_Player2_Vertical = m_Player2.FindAction("Vertical", throwIfNotFound: true);
        m_Player2_Power = m_Player2.FindAction("Power", throwIfNotFound: true);
        m_Player2_CicleDown = m_Player2.FindAction("CicleDown", throwIfNotFound: true);
        m_Player2_CicleUp = m_Player2.FindAction("CicleUp", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Horizontal;
    private readonly InputAction m_Player_Vertical;
    private readonly InputAction m_Player_Power;
    private readonly InputAction m_Player_CicleDown;
    private readonly InputAction m_Player_CicleUp;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Player_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player_Vertical;
        public InputAction @Power => m_Wrapper.m_Player_Power;
        public InputAction @CicleDown => m_Wrapper.m_Player_CicleDown;
        public InputAction @CicleUp => m_Wrapper.m_Player_CicleUp;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVertical;
                @Power.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPower;
                @Power.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPower;
                @Power.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPower;
                @CicleDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCicleDown;
                @CicleDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCicleDown;
                @CicleDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCicleDown;
                @CicleUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCicleUp;
                @CicleUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCicleUp;
                @CicleUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCicleUp;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Power.started += instance.OnPower;
                @Power.performed += instance.OnPower;
                @Power.canceled += instance.OnPower;
                @CicleDown.started += instance.OnCicleDown;
                @CicleDown.performed += instance.OnCicleDown;
                @CicleDown.canceled += instance.OnCicleDown;
                @CicleUp.started += instance.OnCicleUp;
                @CicleUp.performed += instance.OnCicleUp;
                @CicleUp.canceled += instance.OnCicleUp;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Horizontal;
    private readonly InputAction m_Player2_Vertical;
    private readonly InputAction m_Player2_Power;
    private readonly InputAction m_Player2_CicleDown;
    private readonly InputAction m_Player2_CicleUp;
    public struct Player2Actions
    {
        private @PlayerInputActions m_Wrapper;
        public Player2Actions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Player2_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player2_Vertical;
        public InputAction @Power => m_Wrapper.m_Player2_Power;
        public InputAction @CicleDown => m_Wrapper.m_Player2_CicleDown;
        public InputAction @CicleUp => m_Wrapper.m_Player2_CicleUp;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVertical;
                @Power.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPower;
                @Power.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPower;
                @Power.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPower;
                @CicleDown.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCicleDown;
                @CicleDown.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCicleDown;
                @CicleDown.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCicleDown;
                @CicleUp.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCicleUp;
                @CicleUp.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCicleUp;
                @CicleUp.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnCicleUp;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Power.started += instance.OnPower;
                @Power.performed += instance.OnPower;
                @Power.canceled += instance.OnPower;
                @CicleDown.started += instance.OnCicleDown;
                @CicleDown.performed += instance.OnCicleDown;
                @CicleDown.canceled += instance.OnCicleDown;
                @CicleUp.started += instance.OnCicleUp;
                @CicleUp.performed += instance.OnCicleUp;
                @CicleUp.canceled += instance.OnCicleUp;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayerActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnPower(InputAction.CallbackContext context);
        void OnCicleDown(InputAction.CallbackContext context);
        void OnCicleUp(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnPower(InputAction.CallbackContext context);
        void OnCicleDown(InputAction.CallbackContext context);
        void OnCicleUp(InputAction.CallbackContext context);
    }
}
