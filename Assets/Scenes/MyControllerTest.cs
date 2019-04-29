using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.Experimental.Input.Layouts;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;
using UnityEngine.Experimental.Input.Plugins.Users;

public class MyControllerTest : MonoBehaviour
{
    public PlayerInput playerInput;
    
    // TODO: accion continua
    // TODO: obtener valor float de accion
    // TODO: dos o mas controllers, como se identifican?

    [SerializeField]
    private Gamepad _gamepad;

    [SerializeField]
    private InputDevice _inputDevice;

    private InputUser _user = new InputUser();

    private bool _paired;

    [SerializeField]
    private InputActionAsset _inputActions;

    private InputAction _action;
    
    private void Start()
    {
//        foreach (var device in playerInput.devices)
//        {
//            Debug.LogFormat("device: {0},{1}", device.id, device.name);
//            foreach (var control in device.allControls)
//            {
//                Debug.LogFormat("control: {0}, {1}, {2}", control.name, control.valueType, control.layout);
//            }
//        }

        _gamepad = InputSystem.GetDevice<Gamepad>();
        
//        playerInput.deviceLostEvent.AddListener(OnDeviceLost);
//        playerInput.deviceRegainedEvent.AddListener(OnDeviceRegained);
//        _inputDevice = playerInput.devices[0];

        InputUser.listenForUnpairedDeviceActivity = 4;
        InputUser.onUnpairedDeviceUsed += OnInputUserOnOnUnpairedDeviceUsed;
        InputUser.onChange += InputUserOnOnChange;
    }

    private void InputUserOnOnChange(InputUser user, InputUserChange change, InputDevice device)
    {
        Debug.LogFormat("Input changed: {0}, {1}, {2}", user, change, device);
        if (change == InputUserChange.DevicePaired)
        {
            _paired = true;
            var actions = ScriptableObject.Instantiate(_inputActions);
            user.AssociateActionsWithUser(actions);
            // user.ActivateControlScheme()
            _action = actions.FindAction("Fire");
            _action.Enable();
            
            _action.performed += delegate(InputAction.CallbackContext context)
            {
                Debug.Log("on action!");
            };
        }
    }

    private void OnInputUserOnOnUnpairedDeviceUsed(InputControl control)
    {
        if (!_paired)
        {
            if (control.device is Gamepad gamepad)
            {
                Debug.LogFormat("new unpaired device activity: {0}", gamepad.name);
                _user = InputUser.PerformPairingWithDevice(gamepad, new InputUser(),
                    InputUserPairingOptions.UnpairCurrentDevicesFromUser);
            }
        }
    }

    private void OnDeviceRegained(PlayerInput p)
    {
        Debug.LogFormat("Device regained");
    }

    private void OnDeviceLost(PlayerInput p)
    {
        Debug.LogFormat("Device lost");
    }

    private void Update()
    {
        if (_paired && _user.pairedDevices.Count > 0)
        {
            // find paired gamepad...
            var gamepad = _user.pairedDevices[0] as Gamepad;
            Debug.LogFormat("Moving device: {0}", gamepad.leftStick.ReadValue());
        }

//        if (_action != null)
//        {
//            Debug.LogFormat("{0}", _action.lastTriggerTime);
//        }
//        
        // var leftStick = _inputDevice.TryGetChildControl("leftStick");
//        
//        if (_gamepad.enabled){
//            Debug.LogFormat("leftStick: {0}", _gamepad.leftStick.ReadValue());
//            Debug.LogFormat("rightStick: {0}", _gamepad.rightStick.ReadValue());
//        //var pim = PlayerInputManager.instance;
//        }
    }

    public void TestEventMovement(InputAction.CallbackContext inputContext)
    {
        // Debug.LogFormat("{0}", inputContext.action.name);
    }
}
