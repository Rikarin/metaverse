// GENERATED AUTOMATICALLY FROM 'Assets/Settings/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a486b949-c20f-43ad-9a5b-0e663da1476e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b1d05954-081c-438b-8344-255a8ad12126"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""01136042-2215-4533-8b30-5daf65a9cabf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""50b14df1-5797-4425-aab2-de60972bdc50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""6e029ba0-0fb9-4062-a363-8c59e296f3c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8973b512-083d-4a15-97b8-1427b0d63d2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""8f3ec614-15aa-4db8-a75b-c56f9423964c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HalfStack"",
                    ""type"": ""Button"",
                    ""id"": ""99c0b036-3e97-48f8-af0e-50c42cb40edc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backpack"",
                    ""type"": ""Button"",
                    ""id"": ""aa7e0bf0-de1c-4983-9c27-389ff0a51afd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Character"",
                    ""type"": ""Button"",
                    ""id"": ""d524d200-5a76-4fe9-943b-2eaed115999f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JutsuBook"",
                    ""type"": ""Button"",
                    ""id"": ""8b3a3d6e-1411-4fc0-9d28-ab5fb1d79836"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0b602373-68fc-44c9-ae4c-71525215013a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""2c992243-6b3a-4502-a7c7-c70cc02469c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Minimap"",
                    ""type"": ""Button"",
                    ""id"": ""f4804d1f-c4d7-4f91-87e4-6c4a05f344c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterChat"",
                    ""type"": ""Button"",
                    ""id"": ""a111cb0d-5178-4034-a8c2-9fc86b9ef3d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimBracks"",
                    ""type"": ""Button"",
                    ""id"": ""128bab3a-dc7c-45c4-b648-fadbdbadd880"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""bda271ec-8f81-4efb-8522-a278cb4ba9f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondJutsu"",
                    ""type"": ""Button"",
                    ""id"": ""90a8b878-4b12-4d0e-aa9e-18d5aeb2fe4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jutsu0"",
                    ""type"": ""Button"",
                    ""id"": ""611453b3-e937-4472-87df-c01d4295bc95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jutsu1"",
                    ""type"": ""Button"",
                    ""id"": ""4e412e68-2424-4a93-961b-7bbeaae831a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftDash"",
                    ""type"": ""Button"",
                    ""id"": ""c6ee2a18-ffc1-4707-810a-a0260d967629"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""7d10ccb5-ff48-4241-ae0d-193301362523"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""c2279ae5-3b8d-4100-8a77-f855355fe710"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlashChat"",
                    ""type"": ""Button"",
                    ""id"": ""7e5d73fb-0f19-4525-966e-48ac9732ba62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""84bd1649-6a17-4e0d-84f6-f8df963af356"",
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
                    ""id"": ""35d9f534-9b31-49bd-8d96-e30b75dc4b6a"",
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
                    ""id"": ""76d8c6a6-ff24-4ad9-94e7-2f11a71499ba"",
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
                    ""id"": ""ad00a4bc-dca8-4f75-9585-c929d4fd56c2"",
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
                    ""id"": ""124a2bab-dbd1-48fe-bea5-bdb362ff6c4c"",
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
                    ""id"": ""36c06848-b20a-4bce-82f2-746a682789ad"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed1f9778-e305-47a7-8109-3cf3d6998a33"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5184bddf-0f86-44af-8b84-5a4fc9623809"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffb099a4-953c-4145-b2d7-b970a0ebdfb8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f8cefa5-0aa3-4f8a-98ae-51111978377a"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea875d0-8ec8-4ca4-83d6-797520d6286e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HalfStack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29c1ec19-7ce8-490d-a981-b8d03a3179b1"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backpack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5780eb7a-7bf2-4195-93d6-80eeebb61818"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfbf81c1-a20e-499d-98af-d32cb3221ffa"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JutsuBook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c14aa65b-5b5a-4b9a-a016-8b04bb3d9594"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""767cef84-0058-4a17-8d00-76bdf546df4e"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""288516f5-5e4e-49b6-952a-d47335698040"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Minimap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9aa4760-49f5-4980-a8b9-2f33f3ae2a08"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterChat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7229b8d-9c24-487c-b01b-d555f8c4380c"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimBracks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21d8f3de-ac8e-4cf5-8039-f272d8b16fb1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f46b3257-f5f4-49ef-9e0e-c5f4c7a060fe"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondJutsu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5e628c4-94a1-4ba6-95b8-382ffe8b340f"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jutsu0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb3c6bdd-d3d1-4ac5-8374-8aab731380ad"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jutsu1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d97c6de-06dd-4381-ae1b-ac0ae5ab6575"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftDash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06d64b0a-d872-4538-b97d-ecd00e2c69aa"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2,NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41a09f3d-4705-4687-bb60-33f30bb6e576"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a930376-76c9-4998-96d6-273685caa7cd"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlashChat"",
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
        m_Player_LeftClick = m_Player.FindAction("LeftClick", throwIfNotFound: true);
        m_Player_RightClick = m_Player.FindAction("RightClick", throwIfNotFound: true);
        m_Player_ChangeSpeed = m_Player.FindAction("ChangeSpeed", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_CameraSwitch = m_Player.FindAction("CameraSwitch", throwIfNotFound: true);
        m_Player_HalfStack = m_Player.FindAction("HalfStack", throwIfNotFound: true);
        m_Player_Backpack = m_Player.FindAction("Backpack", throwIfNotFound: true);
        m_Player_Character = m_Player.FindAction("Character", throwIfNotFound: true);
        m_Player_JutsuBook = m_Player.FindAction("JutsuBook", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Map = m_Player.FindAction("Map", throwIfNotFound: true);
        m_Player_Minimap = m_Player.FindAction("Minimap", throwIfNotFound: true);
        m_Player_EnterChat = m_Player.FindAction("EnterChat", throwIfNotFound: true);
        m_Player_AimBracks = m_Player.FindAction("AimBracks", throwIfNotFound: true);
        m_Player_Exit = m_Player.FindAction("Exit", throwIfNotFound: true);
        m_Player_SecondJutsu = m_Player.FindAction("SecondJutsu", throwIfNotFound: true);
        m_Player_Jutsu0 = m_Player.FindAction("Jutsu0", throwIfNotFound: true);
        m_Player_Jutsu1 = m_Player.FindAction("Jutsu1", throwIfNotFound: true);
        m_Player_LeftDash = m_Player.FindAction("LeftDash", throwIfNotFound: true);
        m_Player_Camera = m_Player.FindAction("Camera", throwIfNotFound: true);
        m_Player_Scroll = m_Player.FindAction("Scroll", throwIfNotFound: true);
        m_Player_SlashChat = m_Player.FindAction("SlashChat", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_LeftClick;
    private readonly InputAction m_Player_RightClick;
    private readonly InputAction m_Player_ChangeSpeed;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_CameraSwitch;
    private readonly InputAction m_Player_HalfStack;
    private readonly InputAction m_Player_Backpack;
    private readonly InputAction m_Player_Character;
    private readonly InputAction m_Player_JutsuBook;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Map;
    private readonly InputAction m_Player_Minimap;
    private readonly InputAction m_Player_EnterChat;
    private readonly InputAction m_Player_AimBracks;
    private readonly InputAction m_Player_Exit;
    private readonly InputAction m_Player_SecondJutsu;
    private readonly InputAction m_Player_Jutsu0;
    private readonly InputAction m_Player_Jutsu1;
    private readonly InputAction m_Player_LeftDash;
    private readonly InputAction m_Player_Camera;
    private readonly InputAction m_Player_Scroll;
    private readonly InputAction m_Player_SlashChat;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @LeftClick => m_Wrapper.m_Player_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Player_RightClick;
        public InputAction @ChangeSpeed => m_Wrapper.m_Player_ChangeSpeed;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @CameraSwitch => m_Wrapper.m_Player_CameraSwitch;
        public InputAction @HalfStack => m_Wrapper.m_Player_HalfStack;
        public InputAction @Backpack => m_Wrapper.m_Player_Backpack;
        public InputAction @Character => m_Wrapper.m_Player_Character;
        public InputAction @JutsuBook => m_Wrapper.m_Player_JutsuBook;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Map => m_Wrapper.m_Player_Map;
        public InputAction @Minimap => m_Wrapper.m_Player_Minimap;
        public InputAction @EnterChat => m_Wrapper.m_Player_EnterChat;
        public InputAction @AimBracks => m_Wrapper.m_Player_AimBracks;
        public InputAction @Exit => m_Wrapper.m_Player_Exit;
        public InputAction @SecondJutsu => m_Wrapper.m_Player_SecondJutsu;
        public InputAction @Jutsu0 => m_Wrapper.m_Player_Jutsu0;
        public InputAction @Jutsu1 => m_Wrapper.m_Player_Jutsu1;
        public InputAction @LeftDash => m_Wrapper.m_Player_LeftDash;
        public InputAction @Camera => m_Wrapper.m_Player_Camera;
        public InputAction @Scroll => m_Wrapper.m_Player_Scroll;
        public InputAction @SlashChat => m_Wrapper.m_Player_SlashChat;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @LeftClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @ChangeSpeed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeSpeed;
                @ChangeSpeed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeSpeed;
                @ChangeSpeed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeSpeed;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @CameraSwitch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraSwitch;
                @CameraSwitch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraSwitch;
                @CameraSwitch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraSwitch;
                @HalfStack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHalfStack;
                @HalfStack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHalfStack;
                @HalfStack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHalfStack;
                @Backpack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackpack;
                @Backpack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackpack;
                @Backpack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackpack;
                @Character.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCharacter;
                @Character.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCharacter;
                @Character.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCharacter;
                @JutsuBook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsuBook;
                @JutsuBook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsuBook;
                @JutsuBook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsuBook;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Map.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMap;
                @Map.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMap;
                @Map.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMap;
                @Minimap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimap;
                @Minimap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimap;
                @Minimap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimap;
                @EnterChat.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterChat;
                @EnterChat.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterChat;
                @EnterChat.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnterChat;
                @AimBracks.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAimBracks;
                @AimBracks.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAimBracks;
                @AimBracks.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAimBracks;
                @Exit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExit;
                @SecondJutsu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondJutsu;
                @SecondJutsu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondJutsu;
                @SecondJutsu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSecondJutsu;
                @Jutsu0.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsu0;
                @Jutsu0.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsu0;
                @Jutsu0.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsu0;
                @Jutsu1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsu1;
                @Jutsu1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsu1;
                @Jutsu1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJutsu1;
                @LeftDash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftDash;
                @LeftDash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftDash;
                @LeftDash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftDash;
                @Camera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Scroll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScroll;
                @SlashChat.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlashChat;
                @SlashChat.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlashChat;
                @SlashChat.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSlashChat;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @ChangeSpeed.started += instance.OnChangeSpeed;
                @ChangeSpeed.performed += instance.OnChangeSpeed;
                @ChangeSpeed.canceled += instance.OnChangeSpeed;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CameraSwitch.started += instance.OnCameraSwitch;
                @CameraSwitch.performed += instance.OnCameraSwitch;
                @CameraSwitch.canceled += instance.OnCameraSwitch;
                @HalfStack.started += instance.OnHalfStack;
                @HalfStack.performed += instance.OnHalfStack;
                @HalfStack.canceled += instance.OnHalfStack;
                @Backpack.started += instance.OnBackpack;
                @Backpack.performed += instance.OnBackpack;
                @Backpack.canceled += instance.OnBackpack;
                @Character.started += instance.OnCharacter;
                @Character.performed += instance.OnCharacter;
                @Character.canceled += instance.OnCharacter;
                @JutsuBook.started += instance.OnJutsuBook;
                @JutsuBook.performed += instance.OnJutsuBook;
                @JutsuBook.canceled += instance.OnJutsuBook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Map.started += instance.OnMap;
                @Map.performed += instance.OnMap;
                @Map.canceled += instance.OnMap;
                @Minimap.started += instance.OnMinimap;
                @Minimap.performed += instance.OnMinimap;
                @Minimap.canceled += instance.OnMinimap;
                @EnterChat.started += instance.OnEnterChat;
                @EnterChat.performed += instance.OnEnterChat;
                @EnterChat.canceled += instance.OnEnterChat;
                @AimBracks.started += instance.OnAimBracks;
                @AimBracks.performed += instance.OnAimBracks;
                @AimBracks.canceled += instance.OnAimBracks;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @SecondJutsu.started += instance.OnSecondJutsu;
                @SecondJutsu.performed += instance.OnSecondJutsu;
                @SecondJutsu.canceled += instance.OnSecondJutsu;
                @Jutsu0.started += instance.OnJutsu0;
                @Jutsu0.performed += instance.OnJutsu0;
                @Jutsu0.canceled += instance.OnJutsu0;
                @Jutsu1.started += instance.OnJutsu1;
                @Jutsu1.performed += instance.OnJutsu1;
                @Jutsu1.canceled += instance.OnJutsu1;
                @LeftDash.started += instance.OnLeftDash;
                @LeftDash.performed += instance.OnLeftDash;
                @LeftDash.canceled += instance.OnLeftDash;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @SlashChat.started += instance.OnSlashChat;
                @SlashChat.performed += instance.OnSlashChat;
                @SlashChat.canceled += instance.OnSlashChat;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnChangeSpeed(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCameraSwitch(InputAction.CallbackContext context);
        void OnHalfStack(InputAction.CallbackContext context);
        void OnBackpack(InputAction.CallbackContext context);
        void OnCharacter(InputAction.CallbackContext context);
        void OnJutsuBook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnMinimap(InputAction.CallbackContext context);
        void OnEnterChat(InputAction.CallbackContext context);
        void OnAimBracks(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnSecondJutsu(InputAction.CallbackContext context);
        void OnJutsu0(InputAction.CallbackContext context);
        void OnJutsu1(InputAction.CallbackContext context);
        void OnLeftDash(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnSlashChat(InputAction.CallbackContext context);
    }
}
