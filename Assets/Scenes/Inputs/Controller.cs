// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Inputs/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""5c037eaa-5b35-4d29-97ab-6f5a883cc8d8"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""d4dcb397-9903-47df-9354-a04fc4ca68f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftThumb"",
                    ""type"": ""Value"",
                    ""id"": ""240595c3-0430-4b2b-ac3a-133943344bc3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightThumb"",
                    ""type"": ""Value"",
                    ""id"": ""362217ff-d88a-4672-bba3-0d1376b3fdd8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""c8cdad3c-9b67-4326-b6cc-62d6dddea1ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4faa78ac-33c9-498f-9270-84e7f7c0db74"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""997b0709-c047-4377-866a-4e773a96679e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftThumb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1468938-ec62-49db-9c98-30ada9f6d355"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightThumb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01591764-9dfa-4c48-9448-a55cd933da2d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_A = m_Game.FindAction("A", throwIfNotFound: true);
        m_Game_LeftThumb = m_Game.FindAction("LeftThumb", throwIfNotFound: true);
        m_Game_RightThumb = m_Game.FindAction("RightThumb", throwIfNotFound: true);
        m_Game_B = m_Game.FindAction("B", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_A;
    private readonly InputAction m_Game_LeftThumb;
    private readonly InputAction m_Game_RightThumb;
    private readonly InputAction m_Game_B;
    public struct GameActions
    {
        private @Controller m_Wrapper;
        public GameActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Game_A;
        public InputAction @LeftThumb => m_Wrapper.m_Game_LeftThumb;
        public InputAction @RightThumb => m_Wrapper.m_Game_RightThumb;
        public InputAction @B => m_Wrapper.m_Game_B;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_GameActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnA;
                @LeftThumb.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLeftThumb;
                @LeftThumb.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLeftThumb;
                @LeftThumb.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLeftThumb;
                @RightThumb.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRightThumb;
                @RightThumb.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRightThumb;
                @RightThumb.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnRightThumb;
                @B.started -= m_Wrapper.m_GameActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnB;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @LeftThumb.started += instance.OnLeftThumb;
                @LeftThumb.performed += instance.OnLeftThumb;
                @LeftThumb.canceled += instance.OnLeftThumb;
                @RightThumb.started += instance.OnRightThumb;
                @RightThumb.performed += instance.OnRightThumb;
                @RightThumb.canceled += instance.OnRightThumb;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IGameActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnLeftThumb(InputAction.CallbackContext context);
        void OnRightThumb(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
    }
}
