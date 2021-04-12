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
                    ""id"": ""cf91555a-eded-4da4-9dd3-b1b6d86f728b"",
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
                    ""id"": ""79d6e058-188a-42d4-89b2-540e55336000"",
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
                    ""id"": ""bb0562aa-1a62-48f0-816f-417f254842b1"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
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
                    ""name"": ""ReleasePower"",
                    ""type"": ""Button"",
                    ""id"": ""d49bef76-06a4-408e-a61d-ebda5d9215a2"",
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
                    ""id"": ""846b23cb-512c-4692-a7af-6e57d4972fda"",
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
                    ""id"": ""5f771586-54e8-4753-b43e-e54d0b327764"",
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
                    ""id"": ""dd7a60b1-5a7a-4489-b10a-d56050971f0c"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Power"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""848a97c9-9fc5-4bf5-8ad6-de49f24488e1"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleasePower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameMisc"",
            ""id"": ""2e4636b7-ed09-4099-9fc5-4363ae47652d"",
            ""actions"": [
                {
                    ""name"": ""DialoguePass"",
                    ""type"": ""Button"",
                    ""id"": ""b295b318-a2a7-4d5f-b8cb-d60e68180546"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8ed11432-ebd2-4bb4-b51f-cff83e1d70b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7208112c-4183-4427-804b-e2f61ec2f855"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialoguePass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6550af30-b017-4aa2-b328-1e2a23237779"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CardMenu"",
            ""id"": ""a82d2d58-93a9-460d-bd1e-396400e9b2ed"",
            ""actions"": [
                {
                    ""name"": ""GoForward"",
                    ""type"": ""Button"",
                    ""id"": ""03d0dc6c-19a7-4d0d-907b-d80f8116a007"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""089e3107-834f-4604-a0fc-d118174db132"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackToMenu"",
                    ""type"": ""Button"",
                    ""id"": ""1ea14f18-05d8-4cdb-8683-642a6bdba807"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74e69574-06c2-4587-8031-7717b4333bbd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70521dbc-fda7-4ad3-9123-299bb89e7999"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fda8bb61-3165-4fb7-b4dc-33cc2a1ba5f5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84f59df3-d119-4be9-88bf-e0fb51b997a3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb1b51d7-0c79-493f-aa0e-51dbd64ba0db"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""77bff625-2e47-4aae-9ad7-0ab2a6724bf4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ae547de5-f52f-4f07-a54b-c2beee05d046"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""7a748c9d-c40b-49cd-be99-407492f52b1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d191ee42-ed79-4a3a-9bbf-fc0d0f1d5050"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""074f27ed-197a-4d5a-b561-85a1fbc64547"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""67f82d83-98d7-4434-aaf2-e116d67eb6b8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5bbdaf69-6d05-4573-b665-5ec513c986e9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""115ceee7-8b51-42e9-b589-af8f4ccb498f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0062486c-a501-4ebb-a8cd-c544d5ab577a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4635a4d2-61a9-438f-b763-e51261bf14d9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47744ec2-e1f5-419b-ba48-984fbe27b6e0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8767cd11-e0ae-4339-9acf-12a85ed47898"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""92b37a1c-09b6-4e7a-a321-174bd1c224b5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f328240a-6cf5-47c1-86e6-f60ad8b2ec14"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
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
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Horizontal = m_Player2.FindAction("Horizontal", throwIfNotFound: true);
        m_Player2_Vertical = m_Player2.FindAction("Vertical", throwIfNotFound: true);
        m_Player2_Power = m_Player2.FindAction("Power", throwIfNotFound: true);
        m_Player2_ReleasePower = m_Player2.FindAction("ReleasePower", throwIfNotFound: true);
        // GameMisc
        m_GameMisc = asset.FindActionMap("GameMisc", throwIfNotFound: true);
        m_GameMisc_DialoguePass = m_GameMisc.FindAction("DialoguePass", throwIfNotFound: true);
        m_GameMisc_Pause = m_GameMisc.FindAction("Pause", throwIfNotFound: true);
        // CardMenu
        m_CardMenu = asset.FindActionMap("CardMenu", throwIfNotFound: true);
        m_CardMenu_GoForward = m_CardMenu.FindAction("GoForward", throwIfNotFound: true);
        m_CardMenu_GoBackwards = m_CardMenu.FindAction("GoBackwards", throwIfNotFound: true);
        m_CardMenu_BackToMenu = m_CardMenu.FindAction("BackToMenu", throwIfNotFound: true);
        // PauseMenu
        m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
        m_PauseMenu_Move = m_PauseMenu.FindAction("Move", throwIfNotFound: true);
        m_PauseMenu_select = m_PauseMenu.FindAction("select", throwIfNotFound: true);
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
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Player_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player_Vertical;
        public InputAction @Power => m_Wrapper.m_Player_Power;
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
    private readonly InputAction m_Player2_ReleasePower;
    public struct Player2Actions
    {
        private @PlayerInputActions m_Wrapper;
        public Player2Actions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Player2_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player2_Vertical;
        public InputAction @Power => m_Wrapper.m_Player2_Power;
        public InputAction @ReleasePower => m_Wrapper.m_Player2_ReleasePower;
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
                @ReleasePower.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnReleasePower;
                @ReleasePower.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnReleasePower;
                @ReleasePower.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnReleasePower;
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
                @ReleasePower.started += instance.OnReleasePower;
                @ReleasePower.performed += instance.OnReleasePower;
                @ReleasePower.canceled += instance.OnReleasePower;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // GameMisc
    private readonly InputActionMap m_GameMisc;
    private IGameMiscActions m_GameMiscActionsCallbackInterface;
    private readonly InputAction m_GameMisc_DialoguePass;
    private readonly InputAction m_GameMisc_Pause;
    public struct GameMiscActions
    {
        private @PlayerInputActions m_Wrapper;
        public GameMiscActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @DialoguePass => m_Wrapper.m_GameMisc_DialoguePass;
        public InputAction @Pause => m_Wrapper.m_GameMisc_Pause;
        public InputActionMap Get() { return m_Wrapper.m_GameMisc; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameMiscActions set) { return set.Get(); }
        public void SetCallbacks(IGameMiscActions instance)
        {
            if (m_Wrapper.m_GameMiscActionsCallbackInterface != null)
            {
                @DialoguePass.started -= m_Wrapper.m_GameMiscActionsCallbackInterface.OnDialoguePass;
                @DialoguePass.performed -= m_Wrapper.m_GameMiscActionsCallbackInterface.OnDialoguePass;
                @DialoguePass.canceled -= m_Wrapper.m_GameMiscActionsCallbackInterface.OnDialoguePass;
                @Pause.started -= m_Wrapper.m_GameMiscActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameMiscActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameMiscActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameMiscActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DialoguePass.started += instance.OnDialoguePass;
                @DialoguePass.performed += instance.OnDialoguePass;
                @DialoguePass.canceled += instance.OnDialoguePass;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameMiscActions @GameMisc => new GameMiscActions(this);

    // CardMenu
    private readonly InputActionMap m_CardMenu;
    private ICardMenuActions m_CardMenuActionsCallbackInterface;
    private readonly InputAction m_CardMenu_GoForward;
    private readonly InputAction m_CardMenu_GoBackwards;
    private readonly InputAction m_CardMenu_BackToMenu;
    public struct CardMenuActions
    {
        private @PlayerInputActions m_Wrapper;
        public CardMenuActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GoForward => m_Wrapper.m_CardMenu_GoForward;
        public InputAction @GoBackwards => m_Wrapper.m_CardMenu_GoBackwards;
        public InputAction @BackToMenu => m_Wrapper.m_CardMenu_BackToMenu;
        public InputActionMap Get() { return m_Wrapper.m_CardMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CardMenuActions set) { return set.Get(); }
        public void SetCallbacks(ICardMenuActions instance)
        {
            if (m_Wrapper.m_CardMenuActionsCallbackInterface != null)
            {
                @GoForward.started -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnGoForward;
                @GoForward.performed -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnGoForward;
                @GoForward.canceled -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnGoForward;
                @GoBackwards.started -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnGoBackwards;
                @GoBackwards.performed -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnGoBackwards;
                @GoBackwards.canceled -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnGoBackwards;
                @BackToMenu.started -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnBackToMenu;
                @BackToMenu.performed -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnBackToMenu;
                @BackToMenu.canceled -= m_Wrapper.m_CardMenuActionsCallbackInterface.OnBackToMenu;
            }
            m_Wrapper.m_CardMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GoForward.started += instance.OnGoForward;
                @GoForward.performed += instance.OnGoForward;
                @GoForward.canceled += instance.OnGoForward;
                @GoBackwards.started += instance.OnGoBackwards;
                @GoBackwards.performed += instance.OnGoBackwards;
                @GoBackwards.canceled += instance.OnGoBackwards;
                @BackToMenu.started += instance.OnBackToMenu;
                @BackToMenu.performed += instance.OnBackToMenu;
                @BackToMenu.canceled += instance.OnBackToMenu;
            }
        }
    }
    public CardMenuActions @CardMenu => new CardMenuActions(this);

    // PauseMenu
    private readonly InputActionMap m_PauseMenu;
    private IPauseMenuActions m_PauseMenuActionsCallbackInterface;
    private readonly InputAction m_PauseMenu_Move;
    private readonly InputAction m_PauseMenu_select;
    public struct PauseMenuActions
    {
        private @PlayerInputActions m_Wrapper;
        public PauseMenuActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PauseMenu_Move;
        public InputAction @select => m_Wrapper.m_PauseMenu_select;
        public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMenuActions instance)
        {
            if (m_Wrapper.m_PauseMenuActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnMove;
                @select.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnSelect;
                @select.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnSelect;
                @select.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_PauseMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @select.started += instance.OnSelect;
                @select.performed += instance.OnSelect;
                @select.canceled += instance.OnSelect;
            }
        }
    }
    public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
    public interface IPlayerActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnPower(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnPower(InputAction.CallbackContext context);
        void OnReleasePower(InputAction.CallbackContext context);
    }
    public interface IGameMiscActions
    {
        void OnDialoguePass(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface ICardMenuActions
    {
        void OnGoForward(InputAction.CallbackContext context);
        void OnGoBackwards(InputAction.CallbackContext context);
        void OnBackToMenu(InputAction.CallbackContext context);
    }
    public interface IPauseMenuActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
